using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThreatScanner.Helpers;

namespace ThreatScanner
{
    /// <summary>
    /// CSRF Tester — probes target forms for missing/weak CSRF token protections,
    /// SameSite cookie deficiencies, CORS misconfigurations, and optionally
    /// replays a captured request with a forged/missing token to confirm exploitability.
    /// </summary>
    public partial class CsrfTesterForm : Form
    {
        private HttpClient _client;

        public CsrfTesterForm()
        {
            InitializeComponent();
            ResetClient();

            // Enable Delete-key row removal on the custom-headers grid
            ScanHelpers.EnableRowDeletion(dataGridView_Headers);

            if (comboBox_Method.SelectedIndex < 0)
                comboBox_Method.SelectedIndex = 0;
        }

        // ─── HTTP CLIENT ──────────────────────────────────────────────────────────

        private void ResetClient()
        {
            _client?.Dispose();
            var jar = new CookieContainer();
            var handler = new HttpClientHandler
            {
                CookieContainer = jar,
                UseCookies = true,
                AllowAutoRedirect = false
            };
            _client = new HttpClient(handler) { Timeout = TimeSpan.FromSeconds(20) };
            _client.DefaultRequestHeaders.Add("User-Agent",
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) ThreatScanner/1.0");
        }

        // ─── LOGGING ─────────────────────────────────────────────────────────────

        private void Log(string icon, string msg) => ScanHelpers.LogRtb(richTextBox_Output, icon, msg);
        private void LogSep() => ScanHelpers.LogSeparatorRtb(richTextBox_Output);
        private void ClearOut() => ScanHelpers.ClearOutputRtb(richTextBox_Output);

        private void SetProgress(bool running)
        {
            progressBar_Scan.Style = running ? ProgressBarStyle.Marquee : ProgressBarStyle.Blocks;
            if (!running) progressBar_Scan.Value = 0;
        }

        // ─── MAIN SCAN ────────────────────────────────────────────────────────────

        private async void button_Scan_Click(object sender, EventArgs e)
        {
            ClearOut();
            string rawUrl = textBox_Url.Text.Trim();
            if (string.IsNullOrWhiteSpace(rawUrl))
            {
                MessageBox.Show("Enter a target URL.", "ThreatScanner",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string url = ScanHelpers.NormalizeUrl(rawUrl);
            ResetClient();

            button_Scan.Enabled = false;
            SetProgress(true);

            Log("🛡", $"CSRF Scan → {url}");
            LogSep();

            try
            {
                await Task.Run(async () =>
                {
                    // 1. Fetch the page and analyse cookies
                    string html = await FetchAndCheckCookies(url);

                    // 2. Parse all forms and check for CSRF tokens
                    if (!string.IsNullOrEmpty(html))
                        CheckForms(html, url);

                    // 3. CORS origin reflection check
                    await CheckCors(url);

                    // 4. Referer / Origin header enforcement check
                    await CheckRefererEnforcement(url);
                });
            }
            catch (Exception ex)
            {
                Log("❌", "Scan error: " + ex.Message);
            }
            finally
            {
                Invoke((Action)(() =>
                {
                    LogSep();
                    Log("✅", "CSRF scan complete.");
                    button_Scan.Enabled = true;
                    SetProgress(false);
                }));
            }
        }

        // ─── STEP 1: FETCH + COOKIE FLAGS ────────────────────────────────────────

        private async Task<string> FetchAndCheckCookies(string url)
        {
            Invoke((Action)(() =>
            {
                Log("🍪", "── Cookie / SameSite Analysis ──────────────────────");
            }));

            try
            {
                var req = new HttpRequestMessage(HttpMethod.Get, url);
                var resp = await _client.SendAsync(req);
                string html = await resp.Content.ReadAsStringAsync();

                // Collect Set-Cookie headers
                IEnumerable<string> setCookies = Enumerable.Empty<string>();
                if (resp.Headers.Contains("Set-Cookie"))
                    setCookies = resp.Headers.GetValues("Set-Cookie");

                if (!setCookies.Any())
                {
                    Invoke((Action)(() => Log("ℹ️", "No Set-Cookie headers found on initial response.")));
                }
                else
                {
                    foreach (string cookie in setCookies)
                    {
                        string cookieName = cookie.Split('=')[0].Trim();
                        bool hasHttpOnly = cookie.IndexOf("HttpOnly", StringComparison.OrdinalIgnoreCase) >= 0;
                        bool hasSecure = cookie.IndexOf("Secure", StringComparison.OrdinalIgnoreCase) >= 0;
                        bool hasSameSiteStrict = cookie.IndexOf("SameSite=Strict", StringComparison.OrdinalIgnoreCase) >= 0;
                        bool hasSameSiteLax = cookie.IndexOf("SameSite=Lax", StringComparison.OrdinalIgnoreCase) >= 0;
                        bool hasSameSiteNone = cookie.IndexOf("SameSite=None", StringComparison.OrdinalIgnoreCase) >= 0;

                        Invoke((Action)(() =>
                        {
                            Log("🍪", $"Cookie: {cookieName}");
                            Log(hasHttpOnly ? "✅" : "⚠️",
                                $"  HttpOnly: {(hasHttpOnly ? "Yes" : "MISSING — accessible via JavaScript")}");
                            Log(hasSecure ? "✅" : "⚠️",
                                $"  Secure:   {(hasSecure ? "Yes" : "MISSING — sent over plain HTTP")}");

                            if (hasSameSiteStrict)
                                Log("✅", "  SameSite: Strict — best CSRF protection");
                            else if (hasSameSiteLax)
                                Log("⚠️", "  SameSite: Lax — partial protection (GET requests still cross-site)");
                            else if (hasSameSiteNone)
                                Log("🚨", "  SameSite: None — cookie sent on ALL cross-site requests (CSRF risk)");
                            else
                                Log("🚨", "  SameSite: NOT SET — browser may default to Lax, but explicit value required");

                            LogSep();
                        }));
                    }
                }

                return html;
            }
            catch (Exception ex)
            {
                Invoke((Action)(() => Log("❌", "Cookie check failed: " + ex.Message)));
                return null;
            }
        }

        // ─── STEP 2: FORM CSRF TOKEN CHECK ───────────────────────────────────────

        private void CheckForms(string html, string baseUrl)
        {
            Invoke((Action)(() =>
            {
                Log("📋", "── Form CSRF Token Analysis ────────────────────────");
            }));

            // Find all <form> blocks
            var formMatches = Regex.Matches(html, @"<form[\s\S]*?</form>",
                RegexOptions.IgnoreCase | RegexOptions.Multiline);

            if (formMatches.Count == 0)
            {
                Invoke((Action)(() => Log("ℹ️", "No HTML forms found on this page.")));
                return;
            }

            Invoke((Action)(() => Log("ℹ️", $"Found {formMatches.Count} form(s).")));

            // Known CSRF token field name patterns
            var csrfPatterns = new[]
            {
                "csrf", "xsrf", "_token", "authenticity_token", "__requestverificationtoken",
                "csrfmiddlewaretoken", "csrf_token", "anti_csrf", "nonce", "_wpnonce"
            };

            int formIndex = 0;
            foreach (Match formMatch in formMatches)
            {
                formIndex++;
                string formHtml = formMatch.Value;

                // Extract form action
                string action = ExtractAttr(formHtml, "action");
                string method = ExtractAttr(formHtml, "method");
                if (string.IsNullOrEmpty(method)) method = "GET";
                string actionDisplay = string.IsNullOrEmpty(action) ? "(same page)" : action;

                // Find all input fields in this form
                var inputMatches = Regex.Matches(formHtml, @"<input[^>]*>", RegexOptions.IgnoreCase);
                var fieldNames = inputMatches
                    .Cast<Match>()
                    .Select(m => ExtractAttr(m.Value, "name").ToLowerInvariant())
                    .Where(n => !string.IsNullOrEmpty(n))
                    .ToList();

                bool hasCsrfToken = fieldNames.Any(n =>
                    csrfPatterns.Any(p => n.Contains(p)));

                string foundTokenField = hasCsrfToken
                    ? fieldNames.FirstOrDefault(n => csrfPatterns.Any(p => n.Contains(p)))
                    : null;

                // Check if form uses POST (GET forms are generally not CSRF-relevant for state changes)
                bool isPost = method.Equals("POST", StringComparison.OrdinalIgnoreCase);

                Invoke((Action)(() =>
                {
                    Log("📋", $"Form #{formIndex} — Action: {actionDisplay}  Method: {method.ToUpper()}");

                    if (!isPost)
                    {
                        Log("ℹ️", "  GET form — typically not a CSRF risk for state-changing operations.");
                    }
                    else if (hasCsrfToken)
                    {
                        Log("✅", $"  CSRF token found: [{foundTokenField}] — form appears protected.");
                        Log("⚠️", "  ⚡ Verify: token must be unique per session, validated server-side, and not predictable.");
                    }
                    else
                    {
                        Log("🚨", "  NO CSRF TOKEN detected in this POST form — potentially vulnerable!");
                        Log("🚨", $"  Fields found: {string.Join(", ", fieldNames.Take(10))}");
                        Log("🚨", "  An attacker could forge a cross-site request using this form.");
                    }

                    LogSep();
                }));
            }
        }

        // ─── STEP 3: CORS CHECK ───────────────────────────────────────────────────

        private async Task CheckCors(string url)
        {
            Invoke((Action)(() =>
            {
                Log("🌐", "── CORS Origin Reflection Check ────────────────────");
            }));

            try
            {
                // Send a request with a fake attacker origin
                string attackerOrigin = "https://evil-attacker.com";
                var req = new HttpRequestMessage(HttpMethod.Get, url);
                req.Headers.TryAddWithoutValidation("Origin", attackerOrigin);

                var resp = await _client.SendAsync(req);

                string acao = "";
                if (resp.Headers.Contains("Access-Control-Allow-Origin"))
                    acao = string.Join(", ", resp.Headers.GetValues("Access-Control-Allow-Origin"));

                string acac = "";
                if (resp.Headers.Contains("Access-Control-Allow-Credentials"))
                    acac = string.Join(", ", resp.Headers.GetValues("Access-Control-Allow-Credentials"));

                Invoke((Action)(() =>
                {
                    if (string.IsNullOrEmpty(acao))
                    {
                        Log("✅", "Access-Control-Allow-Origin: not present — no CORS policy exposed.");
                    }
                    else if (acao == "*")
                    {
                        Log("⚠️", $"Access-Control-Allow-Origin: * (wildcard)");
                        Log("ℹ️", "  Wildcard alone cannot be combined with credentials, but exposes public data.");
                    }
                    else if (acao.Equals(attackerOrigin, StringComparison.OrdinalIgnoreCase))
                    {
                        Log("🚨", $"Access-Control-Allow-Origin REFLECTS attacker origin: {acao}");
                        if (acac.Equals("true", StringComparison.OrdinalIgnoreCase))
                            Log("🚨", "  Access-Control-Allow-Credentials: true — CRITICAL! Cookies sent cross-origin. CSRF via CORS possible.");
                        else
                            Log("⚠️", "  Credentials not allowed, but arbitrary origin is reflected — review CORS policy.");
                    }
                    else
                    {
                        Log("✅", $"Access-Control-Allow-Origin: {acao} (attacker origin NOT reflected)");
                    }

                    if (!string.IsNullOrEmpty(acac))
                        Log("ℹ️", $"Access-Control-Allow-Credentials: {acac}");

                    LogSep();
                }));
            }
            catch (Exception ex)
            {
                Invoke((Action)(() => Log("❌", "CORS check failed: " + ex.Message)));
            }
        }

        // ─── STEP 4: REFERER / ORIGIN ENFORCEMENT ────────────────────────────────

        private async Task CheckRefererEnforcement(string url)
        {
            Invoke((Action)(() =>
            {
                Log("🔗", "── Referer / Origin Header Enforcement ─────────────");
            }));

            try
            {
                // Test 1: Completely omit the Referer header (default browser cross-site behaviour)
                var req1 = new HttpRequestMessage(HttpMethod.Get, url);
                req1.Headers.TryAddWithoutValidation("Origin", "https://evil-attacker.com");
                var resp1 = await _client.SendAsync(req1);

                // Test 2: Send a mismatched Referer
                var req2 = new HttpRequestMessage(HttpMethod.Get, url);
                req2.Headers.TryAddWithoutValidation("Referer", "https://evil-attacker.com/csrf.html");
                var resp2 = await _client.SendAsync(req2);

                Invoke((Action)(() =>
                {
                    int code1 = (int)resp1.StatusCode;
                    int code2 = (int)resp2.StatusCode;

                    // If both return 200, the server is not checking Origin/Referer
                    bool possiblyEnforced = code1 == 403 || code1 == 401 || code2 == 403 || code2 == 401;

                    Log("ℹ️", $"Request with attacker Origin: HTTP {code1} {resp1.ReasonPhrase}");
                    Log("ℹ️", $"Request with attacker Referer: HTTP {code2} {resp2.ReasonPhrase}");

                    if (possiblyEnforced)
                    {
                        Log("✅", "Server appears to reject requests with mismatched Origin/Referer (403/401).");
                        Log("⚠️", "Verify this applies to ALL state-changing endpoints, not just GET.");
                    }
                    else
                    {
                        Log("⚠️", "Server did NOT reject requests with a forged Origin/Referer.");
                        Log("⚠️", "This alone is not conclusive (many servers intentionally ignore these headers).");
                        Log("ℹ️", "Combine with the form token and SameSite findings above for full risk assessment.");
                    }

                    LogSep();
                }));
            }
            catch (Exception ex)
            {
                Invoke((Action)(() => Log("❌", "Referer check failed: " + ex.Message)));
            }
        }

        // ─── PROOF-OF-CONCEPT FORGE ───────────────────────────────────────────────

        private async void button_ForgeRequest_Click(object sender, EventArgs e)
        {
            ClearOut();

            string rawUrl = textBox_ForgeUrl.Text.Trim();
            if (string.IsNullOrWhiteSpace(rawUrl))
            {
                MessageBox.Show("Enter an endpoint URL for the forge test.", "ThreatScanner",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string url = ScanHelpers.NormalizeUrl(rawUrl);
            string method = comboBox_Method.SelectedItem?.ToString() ?? "POST";
            string body = textBox_ForgeBody.Text.Trim();
            string origin = textBox_ForgeOrigin.Text.Trim();
            bool omitToken = checkBox_OmitToken.Checked;

            var extraHeaders = ScanHelpers.GetEnabledGridRows(dataGridView_Headers, "col_CsrfHdrKey", "col_CsrfHdrValue");

            button_ForgeRequest.Enabled = false;
            SetProgress(true);

            Log("⚡", $"Forged {method} → {url}");
            Log("ℹ️", $"Simulating cross-site request from: {(string.IsNullOrEmpty(origin) ? "(no origin)" : origin)}");
            if (omitToken) Log("🚨", "CSRF token deliberately OMITTED from request.");
            LogSep();

            try
            {
                await Task.Run(async () =>
                {
                    ResetClient();

                    var req = new HttpRequestMessage(new HttpMethod(method), url);

                    if (!string.IsNullOrEmpty(origin))
                    {
                        req.Headers.TryAddWithoutValidation("Origin", origin);
                        req.Headers.TryAddWithoutValidation("Referer", origin + "/csrf-poc.html");
                    }

                    // Attach extra custom headers
                    foreach (var kv in extraHeaders)
                        if (!string.IsNullOrEmpty(kv.Key))
                            req.Headers.TryAddWithoutValidation(kv.Key, kv.Value);

                    // Body
                    if (!string.IsNullOrEmpty(body) && method != "GET" && method != "HEAD")
                    {
                        // Parse as form-urlencoded key=value pairs
                        var pairs = body.Split(new[] { '\r', '\n', '&' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(p => p.Split(new[] { '=' }, 2))
                            .Where(p => p.Length == 2)
                            .Select(p => new KeyValuePair<string, string>(p[0].Trim(), p[1].Trim()))
                            .ToList();

                        if (pairs.Any())
                            req.Content = new FormUrlEncodedContent(pairs);
                        else
                            req.Content = new StringContent(body, Encoding.UTF8, "application/x-www-form-urlencoded");
                    }

                    var resp = await _client.SendAsync(req);
                    string respBody = await resp.Content.ReadAsStringAsync();
                    int code = (int)resp.StatusCode;

                    Invoke((Action)(() =>
                    {
                        string icon = code >= 200 && code < 300 ? "✅"
                                    : code >= 300 && code < 400 ? "ℹ️"
                                    : code >= 400 && code < 500 ? "⚠️"
                                    : "🚨";

                        Log(icon, $"HTTP {code}  {resp.ReasonPhrase}");

                        // CSRF-specific verdict
                        if (code == 403 || code == 401)
                            Log("✅", "Server REJECTED the forged request (403/401) — CSRF protection appears active.");
                        else if (code >= 200 && code < 300)
                            Log("🚨", "Server ACCEPTED the forged cross-site request — endpoint may be CSRF vulnerable!");
                        else if (code >= 300 && code < 400)
                        {
                            string loc = resp.Headers.Location?.ToString() ?? "";
                            if (loc.ToLower().Contains("login"))
                                Log("ℹ️", $"Redirected to login — session not established. Redirect: {loc}");
                            else
                                Log("⚠️", $"Redirect to: {loc} — manual verification needed.");
                        }

                        LogSep();
                        Log("→", "Response headers:");
                        foreach (var h in resp.Headers)
                            foreach (var v in h.Value)
                                Log("→", $"  {h.Key}: {v}");

                        LogSep();
                        if (!string.IsNullOrWhiteSpace(respBody))
                        {
                            string[] lines = respBody.Replace("\r\n", "\n").Replace("\r", "\n").Split('\n');
                            int lineCount = 0;
                            foreach (string line in lines)
                            {
                                if (string.IsNullOrWhiteSpace(line)) continue;
                                string trimmed = line.Length > 300 ? line.Substring(0, 300) + "…" : line;
                                Log("", trimmed);
                                if (++lineCount >= 100)
                                {
                                    Log("…", $"(truncated — {lines.Length} total lines)");
                                    break;
                                }
                            }
                        }
                        else
                        {
                            Log("📄", "(empty response body)");
                        }

                        LogSep();
                    }));
                });
            }
            catch (Exception ex)
            {
                Log("❌", "Request error: " + ex.Message);
            }
            finally
            {
                Invoke((Action)(() =>
                {
                    Log("✅", "Forge test complete.");
                    button_ForgeRequest.Enabled = true;
                    SetProgress(false);
                }));
            }
        }

        // ─── GENERATE PoC HTML ────────────────────────────────────────────────────

        private void button_GeneratePoc_Click(object sender, EventArgs e)
        {
            string targetUrl = ScanHelpers.NormalizeUrl(textBox_ForgeUrl.Text.Trim());
            if (string.IsNullOrWhiteSpace(textBox_ForgeUrl.Text))
            {
                MessageBox.Show("Enter a target URL in the Forge tab first.", "ThreatScanner",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string method = comboBox_Method.SelectedItem?.ToString() ?? "POST";
            string body = textBox_ForgeBody.Text.Trim();

            // Parse body fields
            var fields = body.Split(new[] { '\r', '\n', '&' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(p => p.Split(new[] { '=' }, 2))
                .Where(p => p.Length == 2)
                .Select(p => (Key: Uri.UnescapeDataString(p[0].Trim()), Value: Uri.UnescapeDataString(p[1].Trim())))
                .ToList();

            var sb = new StringBuilder();
            sb.AppendLine("<!DOCTYPE html>");
            sb.AppendLine("<html>");
            sb.AppendLine("<head>");
            sb.AppendLine("  <title>CSRF PoC — ThreatScanner</title>");
            sb.AppendLine("</head>");
            sb.AppendLine("<body>");
            sb.AppendLine("  <h1>CSRF Proof-of-Concept</h1>");
            sb.AppendLine($"  <p>Target: <b>{System.Net.WebUtility.HtmlEncode(targetUrl)}</b></p>");
            sb.AppendLine($"  <form action=\"{System.Net.WebUtility.HtmlEncode(targetUrl)}\" method=\"{method}\" id=\"csrfForm\">");

            if (fields.Any())
            {
                foreach (var (Key, Value) in fields)
                {
                    sb.AppendLine($"    <input type=\"hidden\" name=\"{System.Net.WebUtility.HtmlEncode(Key)}\" " +
                                  $"value=\"{System.Net.WebUtility.HtmlEncode(Value)}\" />");
                }
            }
            else
            {
                sb.AppendLine("    <!-- Add hidden fields here matching the target form -->");
                sb.AppendLine("    <!-- <input type=\"hidden\" name=\"fieldName\" value=\"fieldValue\" /> -->");
            }

            sb.AppendLine("    <input type=\"submit\" value=\"Click me (victim trigger)\" />");
            sb.AppendLine("  </form>");
            sb.AppendLine("  <script>");
            sb.AppendLine("    // Auto-submit on page load (silent attack simulation):");
            sb.AppendLine("    // document.getElementById('csrfForm').submit();");
            sb.AppendLine("  </script>");
            sb.AppendLine("</body>");
            sb.AppendLine("</html>");

            string poc = sb.ToString();

            // Show in output and ask to save
            ClearOut();
            Log("⚡", "Generated CSRF Proof-of-Concept HTML:");
            LogSep();
            foreach (string line in poc.Split(new[] { '\n' }, StringSplitOptions.None))
                Log("", line.TrimEnd());

            LogSep();

            var dlg = new SaveFileDialog
            {
                Filter = "HTML File|*.html",
                FileName = $"CSRF_PoC_{DateTime.Now:yyyyMMdd_HHmmss}.html"
            };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dlg.FileName, poc, Encoding.UTF8);
                MessageBox.Show($"PoC saved:\n{dlg.FileName}", "ThreatScanner",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // ─── HELPERS ─────────────────────────────────────────────────────────────

        private static string ExtractAttr(string tag, string attr)
        {
            foreach (string quote in new[] { "\"", "'" })
            {
                string pattern = $"{attr}={quote}";
                int start = tag.IndexOf(pattern, StringComparison.OrdinalIgnoreCase);
                if (start >= 0)
                {
                    start += pattern.Length;
                    int end = tag.IndexOf(quote, start);
                    if (end >= 0) return tag.Substring(start, end - start);
                }
            }
            // attr=value with no quotes
            var m = Regex.Match(tag, $@"{attr}=([^\s>]+)", RegexOptions.IgnoreCase);
            return m.Success ? m.Groups[1].Value : "";
        }

        // ─── SAVE / CLEAR ─────────────────────────────────────────────────────────

        private void button_SaveReport_Click(object sender, EventArgs e)
        {
            if (richTextBox_Output.TextLength == 0) return;
            var dlg = new SaveFileDialog
            {
                Filter = "Text File|*.txt",
                FileName = $"CSRF_Report_{DateTime.Now:yyyyMMdd_HHmmss}"
            };
            if (dlg.ShowDialog() == DialogResult.OK)
                File.WriteAllText(dlg.FileName, richTextBox_Output.Text, Encoding.UTF8);
        }

        private void button_ClearOutput_Click(object sender, EventArgs e) => ClearOut();
    }
}