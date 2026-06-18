namespace ThreatScanner
{
    partial class CsrfTesterForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panel_TopBar = new System.Windows.Forms.Panel();
            this.label_Title = new System.Windows.Forms.Label();
            this.label_Subtitle = new System.Windows.Forms.Label();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.tabControl_Main = new System.Windows.Forms.TabControl();
            this.tabPage_Scan = new System.Windows.Forms.TabPage();
            this.label_ScanUrl = new System.Windows.Forms.Label();
            this.textBox_Url = new System.Windows.Forms.TextBox();
            this.button_Scan = new System.Windows.Forms.Button();
            this.tabPage_Forge = new System.Windows.Forms.TabPage();
            this.label_ForgeUrl = new System.Windows.Forms.Label();
            this.textBox_ForgeUrl = new System.Windows.Forms.TextBox();
            this.label_Method = new System.Windows.Forms.Label();
            this.comboBox_Method = new System.Windows.Forms.ComboBox();
            this.label_ForgeOrigin = new System.Windows.Forms.Label();
            this.textBox_ForgeOrigin = new System.Windows.Forms.TextBox();
            this.label_ForgeBody = new System.Windows.Forms.Label();
            this.textBox_ForgeBody = new System.Windows.Forms.TextBox();
            this.checkBox_OmitToken = new System.Windows.Forms.CheckBox();
            this.label_CustomHeaders = new System.Windows.Forms.Label();
            this.dataGridView_Headers = new System.Windows.Forms.DataGridView();
            this.col_CsrfHdrKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CsrfHdrValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_ForgeRequest = new System.Windows.Forms.Button();
            this.button_GeneratePoc = new System.Windows.Forms.Button();
            this.panel_Output = new System.Windows.Forms.Panel();
            this.richTextBox_Output = new System.Windows.Forms.RichTextBox();
            this.progressBar_Scan = new System.Windows.Forms.ProgressBar();
            this.panel_BottomBar = new System.Windows.Forms.Panel();
            this.button_SaveReport = new System.Windows.Forms.Button();
            this.button_ClearOutput = new System.Windows.Forms.Button();
            this.label_Disclaimer = new System.Windows.Forms.Label();

            this.panel_TopBar.SuspendLayout();
            this.panel_Main.SuspendLayout();
            this.tabControl_Main.SuspendLayout();
            this.tabPage_Scan.SuspendLayout();
            this.tabPage_Forge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Headers)).BeginInit();
            this.panel_Output.SuspendLayout();
            this.panel_BottomBar.SuspendLayout();
            this.SuspendLayout();

            // ── panel_TopBar ──────────────────────────────────────────────────────
            this.panel_TopBar.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.panel_TopBar.Controls.Add(this.label_Title);
            this.panel_TopBar.Controls.Add(this.label_Subtitle);
            this.panel_TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_TopBar.Location = new System.Drawing.Point(0, 0);
            this.panel_TopBar.Name = "panel_TopBar";
            this.panel_TopBar.Size = new System.Drawing.Size(1100, 66);
            this.panel_TopBar.TabIndex = 0;

            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label_Title.ForeColor = System.Drawing.Color.White;
            this.label_Title.Location = new System.Drawing.Point(16, 8);
            this.label_Title.Name = "label_Title";
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "🛡  CSRF Tester";

            this.label_Subtitle.AutoSize = true;
            this.label_Subtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label_Subtitle.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.label_Subtitle.Location = new System.Drawing.Point(18, 40);
            this.label_Subtitle.Name = "label_Subtitle";
            this.label_Subtitle.TabIndex = 1;
            this.label_Subtitle.Text = "Scan for missing CSRF tokens · SameSite cookies · CORS misconfig · Forge cross-site requests";

            // ── panel_Main (left: tabs | right: output) ───────────────────────────
            this.panel_Main.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Controls.Add(this.panel_Output);
            this.panel_Main.Controls.Add(this.tabControl_Main);
            this.panel_Main.Location = new System.Drawing.Point(0, 66);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(1100, 560);
            this.panel_Main.TabIndex = 1;

            // ── tabControl_Main ───────────────────────────────────────────────────
            this.tabControl_Main.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl_Main.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.tabControl_Main.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.Size = new System.Drawing.Size(440, 560);
            this.tabControl_Main.TabIndex = 0;
            this.tabControl_Main.Controls.Add(this.tabPage_Scan);
            this.tabControl_Main.Controls.Add(this.tabPage_Forge);

            // ── tabPage_Scan ──────────────────────────────────────────────────────
            this.tabPage_Scan.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            this.tabPage_Scan.Controls.Add(this.label_ScanUrl);
            this.tabPage_Scan.Controls.Add(this.textBox_Url);
            this.tabPage_Scan.Controls.Add(this.button_Scan);
            this.tabPage_Scan.Location = new System.Drawing.Point(4, 28);
            this.tabPage_Scan.Name = "tabPage_Scan";
            this.tabPage_Scan.Padding = new System.Windows.Forms.Padding(10);
            this.tabPage_Scan.Size = new System.Drawing.Size(432, 528);
            this.tabPage_Scan.TabIndex = 0;
            this.tabPage_Scan.Text = "🔍  Scan";

            this.label_ScanUrl.AutoSize = true;
            this.label_ScanUrl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label_ScanUrl.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.label_ScanUrl.Location = new System.Drawing.Point(14, 16);
            this.label_ScanUrl.Name = "label_ScanUrl";
            this.label_ScanUrl.TabIndex = 0;
            this.label_ScanUrl.Text = "Target URL";

            this.textBox_Url.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Url.Font = new System.Drawing.Font("Consolas", 10F);
            this.textBox_Url.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.textBox_Url.Location = new System.Drawing.Point(14, 36);
            this.textBox_Url.Name = "textBox_Url";
            //this.textBox_Url.PlaceholderText = "https://example.com/login";
            this.textBox_Url.Size = new System.Drawing.Size(404, 26);
            this.textBox_Url.TabIndex = 1;

            this.button_Scan.BackColor = System.Drawing.Color.FromArgb(79, 70, 229);
            this.button_Scan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Scan.FlatAppearance.BorderSize = 0;
            this.button_Scan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Scan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button_Scan.ForeColor = System.Drawing.Color.White;
            this.button_Scan.Location = new System.Drawing.Point(14, 76);
            this.button_Scan.Name = "button_Scan";
            this.button_Scan.Size = new System.Drawing.Size(200, 38);
            this.button_Scan.TabIndex = 2;
            this.button_Scan.Text = "▶  Run CSRF Scan";
            this.button_Scan.UseVisualStyleBackColor = false;
            this.button_Scan.Click += new System.EventHandler(this.button_Scan_Click);

            // ── Scan hints label ──────────────────────────────────────────────────
            var label_ScanHints = new System.Windows.Forms.Label();
            label_ScanHints.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            label_ScanHints.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            label_ScanHints.Location = new System.Drawing.Point(14, 128);
            label_ScanHints.Name = "label_ScanHints";
            label_ScanHints.Size = new System.Drawing.Size(404, 340);
            label_ScanHints.TabIndex = 3;
            label_ScanHints.Text =
                "What this scan checks:\r\n\r\n" +
                "🍪  Cookie flags — HttpOnly, Secure, SameSite\r\n" +
                "    (Strict = best, Lax = partial, None = vulnerable)\r\n\r\n" +
                "📋  All HTML forms — looks for CSRF token fields\r\n" +
                "    (csrf, xsrf, _token, authenticity_token, etc.)\r\n" +
                "    POST forms with no token are flagged 🚨\r\n\r\n" +
                "🌐  CORS — sends an attacker Origin header and\r\n" +
                "    checks if the server reflects it with credentials\r\n\r\n" +
                "🔗  Referer / Origin enforcement — sends requests\r\n" +
                "    with a forged Referer and checks for 403/401\r\n\r\n" +
                "─────────────────────────────────────────────\r\n\r\n" +
                "Use the  ⚡ Forge  tab to replay a specific\r\n" +
                "endpoint with a missing or tampered token.";
            this.tabPage_Scan.Controls.Add(label_ScanHints);

            // ── tabPage_Forge ─────────────────────────────────────────────────────
            this.tabPage_Forge.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            this.tabPage_Forge.Controls.Add(this.label_ForgeUrl);
            this.tabPage_Forge.Controls.Add(this.textBox_ForgeUrl);
            this.tabPage_Forge.Controls.Add(this.label_Method);
            this.tabPage_Forge.Controls.Add(this.comboBox_Method);
            this.tabPage_Forge.Controls.Add(this.label_ForgeOrigin);
            this.tabPage_Forge.Controls.Add(this.textBox_ForgeOrigin);
            this.tabPage_Forge.Controls.Add(this.label_ForgeBody);
            this.tabPage_Forge.Controls.Add(this.textBox_ForgeBody);
            this.tabPage_Forge.Controls.Add(this.checkBox_OmitToken);
            this.tabPage_Forge.Controls.Add(this.label_CustomHeaders);
            this.tabPage_Forge.Controls.Add(this.dataGridView_Headers);
            this.tabPage_Forge.Controls.Add(this.button_ForgeRequest);
            this.tabPage_Forge.Controls.Add(this.button_GeneratePoc);
            this.tabPage_Forge.Location = new System.Drawing.Point(4, 28);
            this.tabPage_Forge.Name = "tabPage_Forge";
            this.tabPage_Forge.Padding = new System.Windows.Forms.Padding(10);
            this.tabPage_Forge.Size = new System.Drawing.Size(432, 528);
            this.tabPage_Forge.TabIndex = 1;
            this.tabPage_Forge.Text = "⚡  Forge Request";

            // Forge URL
            this.label_ForgeUrl.AutoSize = true;
            this.label_ForgeUrl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label_ForgeUrl.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.label_ForgeUrl.Location = new System.Drawing.Point(14, 14);
            this.label_ForgeUrl.Name = "label_ForgeUrl";
            this.label_ForgeUrl.TabIndex = 0;
            this.label_ForgeUrl.Text = "Endpoint URL";

            this.textBox_ForgeUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_ForgeUrl.Font = new System.Drawing.Font("Consolas", 10F);
            this.textBox_ForgeUrl.Location = new System.Drawing.Point(14, 34);
            this.textBox_ForgeUrl.Name = "textBox_ForgeUrl";
            //this.textBox_ForgeUrl.PlaceholderText = "https://example.com/change-email";
            this.textBox_ForgeUrl.Size = new System.Drawing.Size(404, 26);
            this.textBox_ForgeUrl.TabIndex = 1;

            // Method
            this.label_Method.AutoSize = true;
            this.label_Method.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label_Method.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.label_Method.Location = new System.Drawing.Point(14, 72);
            this.label_Method.Name = "label_Method";
            this.label_Method.TabIndex = 2;
            this.label_Method.Text = "Method";

            this.comboBox_Method.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Method.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.comboBox_Method.Items.AddRange(new object[] { "POST", "GET", "PUT", "PATCH", "DELETE" });
            this.comboBox_Method.Location = new System.Drawing.Point(14, 92);
            this.comboBox_Method.Name = "comboBox_Method";
            this.comboBox_Method.Size = new System.Drawing.Size(120, 27);
            this.comboBox_Method.TabIndex = 3;

            // Attacker Origin
            this.label_ForgeOrigin.AutoSize = true;
            this.label_ForgeOrigin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label_ForgeOrigin.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.label_ForgeOrigin.Location = new System.Drawing.Point(150, 72);
            this.label_ForgeOrigin.Name = "label_ForgeOrigin";
            this.label_ForgeOrigin.TabIndex = 4;
            this.label_ForgeOrigin.Text = "Attacker Origin (sent as Origin/Referer)";

            this.textBox_ForgeOrigin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_ForgeOrigin.Font = new System.Drawing.Font("Consolas", 9.5F);
            this.textBox_ForgeOrigin.Location = new System.Drawing.Point(150, 92);
            this.textBox_ForgeOrigin.Name = "textBox_ForgeOrigin";
            //this.textBox_ForgeOrigin.PlaceholderText = "https://evil-attacker.com";
            this.textBox_ForgeOrigin.Size = new System.Drawing.Size(268, 26);
            this.textBox_ForgeOrigin.TabIndex = 5;
            this.textBox_ForgeOrigin.Text = "https://evil-attacker.com";

            // Body
            this.label_ForgeBody.AutoSize = true;
            this.label_ForgeBody.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label_ForgeBody.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.label_ForgeBody.Location = new System.Drawing.Point(14, 132);
            this.label_ForgeBody.Name = "label_ForgeBody";
            this.label_ForgeBody.TabIndex = 6;
            this.label_ForgeBody.Text = "Request Body  (key=value, one per line or &-separated)";

            this.textBox_ForgeBody.AcceptsReturn = true;
            this.textBox_ForgeBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_ForgeBody.Font = new System.Drawing.Font("Consolas", 9.5F);
            this.textBox_ForgeBody.Location = new System.Drawing.Point(14, 152);
            this.textBox_ForgeBody.Multiline = true;
            this.textBox_ForgeBody.Name = "textBox_ForgeBody";
            // this.textBox_ForgeBody.PlaceholderText = "email=attacker@evil.com\r\naction=update";
            this.textBox_ForgeBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_ForgeBody.Size = new System.Drawing.Size(404, 90);
            this.textBox_ForgeBody.TabIndex = 7;

            // Omit Token checkbox
            this.checkBox_OmitToken.AutoSize = true;
            this.checkBox_OmitToken.Checked = true;
            this.checkBox_OmitToken.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_OmitToken.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkBox_OmitToken.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.checkBox_OmitToken.Location = new System.Drawing.Point(14, 252);
            this.checkBox_OmitToken.Name = "checkBox_OmitToken";
            this.checkBox_OmitToken.TabIndex = 8;
            this.checkBox_OmitToken.Text = "Omit CSRF token (simulate forged cross-site request)";

            // Custom Headers grid
            this.label_CustomHeaders.AutoSize = true;
            this.label_CustomHeaders.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label_CustomHeaders.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.label_CustomHeaders.Location = new System.Drawing.Point(14, 280);
            this.label_CustomHeaders.Name = "label_CustomHeaders";
            this.label_CustomHeaders.TabIndex = 9;
            this.label_CustomHeaders.Text = "Extra Headers  (optional)";

            this.dataGridView_Headers.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Headers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataGridView_Headers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Headers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
            {
                this.col_CsrfHdrKey,
                this.col_CsrfHdrValue
            });
            this.dataGridView_Headers.Location = new System.Drawing.Point(14, 300);
            this.dataGridView_Headers.Name = "dataGridView_Headers";
            this.dataGridView_Headers.RowHeadersWidth = 24;
            this.dataGridView_Headers.Size = new System.Drawing.Size(404, 100);
            this.dataGridView_Headers.TabIndex = 10;

            this.col_CsrfHdrKey.HeaderText = "Header Name";
            this.col_CsrfHdrKey.Name = "col_CsrfHdrKey";
            this.col_CsrfHdrKey.Width = 180;

            this.col_CsrfHdrValue.HeaderText = "Value";
            this.col_CsrfHdrValue.Name = "col_CsrfHdrValue";
            this.col_CsrfHdrValue.Width = 200;

            // Forge button
            this.button_ForgeRequest.BackColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.button_ForgeRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ForgeRequest.FlatAppearance.BorderSize = 0;
            this.button_ForgeRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ForgeRequest.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button_ForgeRequest.ForeColor = System.Drawing.Color.White;
            this.button_ForgeRequest.Location = new System.Drawing.Point(14, 414);
            this.button_ForgeRequest.Name = "button_ForgeRequest";
            this.button_ForgeRequest.Size = new System.Drawing.Size(192, 38);
            this.button_ForgeRequest.TabIndex = 11;
            this.button_ForgeRequest.Text = "⚡  Send Forged Request";
            this.button_ForgeRequest.UseVisualStyleBackColor = false;
            this.button_ForgeRequest.Click += new System.EventHandler(this.button_ForgeRequest_Click);

            // Generate PoC button
            this.button_GeneratePoc.BackColor = System.Drawing.Color.FromArgb(217, 119, 6);
            this.button_GeneratePoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_GeneratePoc.FlatAppearance.BorderSize = 0;
            this.button_GeneratePoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_GeneratePoc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button_GeneratePoc.ForeColor = System.Drawing.Color.White;
            this.button_GeneratePoc.Location = new System.Drawing.Point(218, 414);
            this.button_GeneratePoc.Name = "button_GeneratePoc";
            this.button_GeneratePoc.Size = new System.Drawing.Size(200, 38);
            this.button_GeneratePoc.TabIndex = 12;
            this.button_GeneratePoc.Text = "📄  Generate PoC HTML";
            this.button_GeneratePoc.UseVisualStyleBackColor = false;
            this.button_GeneratePoc.Click += new System.EventHandler(this.button_GeneratePoc_Click);

            // ── panel_Output (right side) ─────────────────────────────────────────
            this.panel_Output.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.panel_Output.Controls.Add(this.richTextBox_Output);
            this.panel_Output.Controls.Add(this.progressBar_Scan);
            this.panel_Output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Output.Location = new System.Drawing.Point(440, 0);
            this.panel_Output.Name = "panel_Output";
            this.panel_Output.Padding = new System.Windows.Forms.Padding(8, 8, 8, 4);
            this.panel_Output.Size = new System.Drawing.Size(660, 560);
            this.panel_Output.TabIndex = 1;

            this.richTextBox_Output.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.richTextBox_Output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_Output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_Output.Font = new System.Drawing.Font("Consolas", 9.5F);
            this.richTextBox_Output.ForeColor = System.Drawing.Color.FromArgb(212, 212, 212);
            this.richTextBox_Output.Location = new System.Drawing.Point(8, 8);
            this.richTextBox_Output.Name = "richTextBox_Output";
            this.richTextBox_Output.ReadOnly = true;
            this.richTextBox_Output.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox_Output.TabIndex = 0;
            this.richTextBox_Output.Text = "";
            this.richTextBox_Output.WordWrap = false;

            this.progressBar_Scan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar_Scan.Location = new System.Drawing.Point(8, 548);
            this.progressBar_Scan.Name = "progressBar_Scan";
            this.progressBar_Scan.Size = new System.Drawing.Size(644, 8);
            this.progressBar_Scan.Style = System.Windows.Forms.ProgressBarStyle.Blocks;
            this.progressBar_Scan.TabIndex = 1;

            // ── panel_BottomBar ───────────────────────────────────────────────────
            this.panel_BottomBar.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.panel_BottomBar.Controls.Add(this.button_SaveReport);
            this.panel_BottomBar.Controls.Add(this.button_ClearOutput);
            this.panel_BottomBar.Controls.Add(this.label_Disclaimer);
            this.panel_BottomBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_BottomBar.Location = new System.Drawing.Point(0, 626);
            this.panel_BottomBar.Name = "panel_BottomBar";
            this.panel_BottomBar.Size = new System.Drawing.Size(1100, 38);
            this.panel_BottomBar.TabIndex = 2;

            this.button_SaveReport.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.button_SaveReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_SaveReport.FlatAppearance.BorderSize = 0;
            this.button_SaveReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SaveReport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_SaveReport.ForeColor = System.Drawing.Color.White;
            this.button_SaveReport.Location = new System.Drawing.Point(8, 6);
            this.button_SaveReport.Name = "button_SaveReport";
            this.button_SaveReport.Size = new System.Drawing.Size(130, 26);
            this.button_SaveReport.TabIndex = 0;
            this.button_SaveReport.Text = "💾  Save Report";
            this.button_SaveReport.UseVisualStyleBackColor = false;
            this.button_SaveReport.Click += new System.EventHandler(this.button_SaveReport_Click);

            this.button_ClearOutput.BackColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.button_ClearOutput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ClearOutput.FlatAppearance.BorderSize = 0;
            this.button_ClearOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ClearOutput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_ClearOutput.ForeColor = System.Drawing.Color.White;
            this.button_ClearOutput.Location = new System.Drawing.Point(148, 6);
            this.button_ClearOutput.Name = "button_ClearOutput";
            this.button_ClearOutput.Size = new System.Drawing.Size(110, 26);
            this.button_ClearOutput.TabIndex = 1;
            this.button_ClearOutput.Text = "🗑  Clear";
            this.button_ClearOutput.UseVisualStyleBackColor = false;
            this.button_ClearOutput.Click += new System.EventHandler(this.button_ClearOutput_Click);

            this.label_Disclaimer.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_Disclaimer.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.label_Disclaimer.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.label_Disclaimer.Location = new System.Drawing.Point(600, 0);
            this.label_Disclaimer.Name = "label_Disclaimer";
            this.label_Disclaimer.Size = new System.Drawing.Size(500, 38);
            this.label_Disclaimer.TabIndex = 2;
            this.label_Disclaimer.Text = "⚠️  For authorized penetration testing only. Unauthorized use is illegal.";
            this.label_Disclaimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // ── CsrfTesterForm ────────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            this.ClientSize = new System.Drawing.Size(1100, 664);
            this.Controls.Add(this.panel_Main);
            this.Controls.Add(this.panel_BottomBar);
            this.Controls.Add(this.panel_TopBar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "CsrfTesterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThreatScanner — CSRF Tester";

            this.panel_TopBar.ResumeLayout(false);
            this.panel_TopBar.PerformLayout();
            this.panel_Main.ResumeLayout(false);
            this.tabControl_Main.ResumeLayout(false);
            this.tabPage_Scan.ResumeLayout(false);
            this.tabPage_Scan.PerformLayout();
            this.tabPage_Forge.ResumeLayout(false);
            this.tabPage_Forge.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Headers)).EndInit();
            this.panel_Output.ResumeLayout(false);
            this.panel_BottomBar.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        // ── Controls ─────────────────────────────────────────────────────────────
        private System.Windows.Forms.Panel panel_TopBar;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_Subtitle;
        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.TabControl tabControl_Main;
        private System.Windows.Forms.TabPage tabPage_Scan;
        private System.Windows.Forms.Label label_ScanUrl;
        private System.Windows.Forms.TextBox textBox_Url;
        private System.Windows.Forms.Button button_Scan;
        private System.Windows.Forms.TabPage tabPage_Forge;
        private System.Windows.Forms.Label label_ForgeUrl;
        private System.Windows.Forms.TextBox textBox_ForgeUrl;
        private System.Windows.Forms.Label label_Method;
        private System.Windows.Forms.ComboBox comboBox_Method;
        private System.Windows.Forms.Label label_ForgeOrigin;
        private System.Windows.Forms.TextBox textBox_ForgeOrigin;
        private System.Windows.Forms.Label label_ForgeBody;
        private System.Windows.Forms.TextBox textBox_ForgeBody;
        private System.Windows.Forms.CheckBox checkBox_OmitToken;
        private System.Windows.Forms.Label label_CustomHeaders;
        private System.Windows.Forms.DataGridView dataGridView_Headers;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CsrfHdrKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CsrfHdrValue;
        private System.Windows.Forms.Button button_ForgeRequest;
        private System.Windows.Forms.Button button_GeneratePoc;
        private System.Windows.Forms.Panel panel_Output;
        private System.Windows.Forms.RichTextBox richTextBox_Output;
        private System.Windows.Forms.ProgressBar progressBar_Scan;
        private System.Windows.Forms.Panel panel_BottomBar;
        private System.Windows.Forms.Button button_SaveReport;
        private System.Windows.Forms.Button button_ClearOutput;
        private System.Windows.Forms.Label label_Disclaimer;
    }
}