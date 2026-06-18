namespace ThreatScanner
{
    partial class WebSocketForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            // ── Declare all controls ──────────────────────────────────────────────
            this.panel_TopBar = new System.Windows.Forms.Panel();
            this.label_Title = new System.Windows.Forms.Label();
            this.label_Subtitle = new System.Windows.Forms.Label();

            // Outer splitter: TOP = config panel, BOTTOM = message log grid
            this.splitContainer_Main = new System.Windows.Forms.SplitContainer();

            // ── TOP panel: left TableLayout ───────────────────────────────────────
            this.tableLayout_Top = new System.Windows.Forms.TableLayoutPanel();

            // Row 0 – URL bar
            this.panel_UrlRow = new System.Windows.Forms.Panel();
            this.label_WsUrl = new System.Windows.Forms.Label();
            this.textBox_WsUrl = new System.Windows.Forms.TextBox();
            this.button_Connect = new System.Windows.Forms.Button();
            this.button_Disconnect = new System.Windows.Forms.Button();
            this.button_TestConnection = new System.Windows.Forms.Button();

            // Row 1 – Subprotocol
            this.panel_SubRow = new System.Windows.Forms.Panel();
            this.label_SubProto = new System.Windows.Forms.Label();
            this.textBox_SubProtocol = new System.Windows.Forms.TextBox();

            // Row 2 – Tab control (Send / Fuzz / Headers)
            this.tabControl_Left = new System.Windows.Forms.TabControl();

            // Tab: Send
            this.tabPage_Message = new System.Windows.Forms.TabPage();
            this.tableLayout_Send = new System.Windows.Forms.TableLayoutPanel();
            this.label_MsgHint = new System.Windows.Forms.Label();
            this.richTextBox_Message = new System.Windows.Forms.RichTextBox();
            this.panel_SendBottom = new System.Windows.Forms.Panel();
            this.checkBox_SendBinary = new System.Windows.Forms.CheckBox();
            this.button_Send = new System.Windows.Forms.Button();

            // Tab: Fuzz
            this.tabPage_Fuzz = new System.Windows.Forms.TabPage();
            this.tableLayout_Fuzz = new System.Windows.Forms.TableLayoutPanel();
            this.label_FuzzHint = new System.Windows.Forms.Label();
            this.panel_FuzzWordlistRow = new System.Windows.Forms.Panel();
            this.label_FuzzWordlist = new System.Windows.Forms.Label();
            this.textBox_FuzzWordlist = new System.Windows.Forms.TextBox();
            this.button_BrowseFuzzWordlist = new System.Windows.Forms.Button();
            this.panel_FuzzDelayRow = new System.Windows.Forms.Panel();
            this.label_FuzzDelay = new System.Windows.Forms.Label();
            this.numericUpDown_FuzzDelay = new System.Windows.Forms.NumericUpDown();
            this.button_Fuzz = new System.Windows.Forms.Button();

            // Tab: Headers
            this.tabPage_Headers = new System.Windows.Forms.TabPage();
            this.dataGridView_Headers = new System.Windows.Forms.DataGridView();
            this.col_WsHdrEnabled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_WsHdrKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_WsHdrValue = new System.Windows.Forms.DataGridViewTextBoxColumn();

            // ── BOTTOM panel: message log as DataGridView ─────────────────────────
            this.tableLayout_Bottom = new System.Windows.Forms.TableLayoutPanel();
            this.panel_OutputBar = new System.Windows.Forms.Panel();
            this.label_OutputTitle = new System.Windows.Forms.Label();
            this.progressBar_Scan = new System.Windows.Forms.ProgressBar();
            this.button_SaveReport = new System.Windows.Forms.Button();
            this.button_ClearOutput = new System.Windows.Forms.Button();
            this.dataGridView_Output = new System.Windows.Forms.DataGridView();
            this.col_Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Direction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Data = new System.Windows.Forms.DataGridViewTextBoxColumn();

            // ── SuspendLayout ─────────────────────────────────────────────────────
            this.panel_TopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Main)).BeginInit();
            this.splitContainer_Main.SuspendLayout();
            this.tableLayout_Top.SuspendLayout();
            this.panel_UrlRow.SuspendLayout();
            this.panel_SubRow.SuspendLayout();
            this.tabControl_Left.SuspendLayout();
            this.tabPage_Message.SuspendLayout();
            this.tableLayout_Send.SuspendLayout();
            this.panel_SendBottom.SuspendLayout();
            this.tabPage_Fuzz.SuspendLayout();
            this.tableLayout_Fuzz.SuspendLayout();
            this.panel_FuzzWordlistRow.SuspendLayout();
            this.panel_FuzzDelayRow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FuzzDelay)).BeginInit();
            this.tabPage_Headers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Headers)).BeginInit();
            this.tableLayout_Bottom.SuspendLayout();
            this.panel_OutputBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Output)).BeginInit();
            this.SuspendLayout();

            // ════════════════════════════════════════════════════════════════════
            //  panel_TopBar
            // ════════════════════════════════════════════════════════════════════
            this.panel_TopBar.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.panel_TopBar.Controls.Add(this.label_Subtitle);
            this.panel_TopBar.Controls.Add(this.label_Title);
            this.panel_TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_TopBar.Height = 66;
            this.panel_TopBar.Name = "panel_TopBar";

            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label_Title.ForeColor = System.Drawing.Color.White;
            this.label_Title.Location = new System.Drawing.Point(14, 7);
            this.label_Title.Text = "🟠  WebSocket Tester";

            this.label_Subtitle.AutoSize = true;
            this.label_Subtitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label_Subtitle.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.label_Subtitle.Location = new System.Drawing.Point(16, 42);
            this.label_Subtitle.Text = "Connect · Send · Receive · Fuzz WebSocket endpoints";

            // ════════════════════════════════════════════════════════════════════
            //  splitContainer_Main  (Horizontal = top/bottom)
            // ════════════════════════════════════════════════════════════════════
            this.splitContainer_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Main.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.splitContainer_Main.SplitterDistance = 360;   // top config area height
            this.splitContainer_Main.SplitterWidth = 5;
            this.splitContainer_Main.Panel1MinSize = 280;
            this.splitContainer_Main.Panel2MinSize = 200;
            this.splitContainer_Main.Panel1.Controls.Add(this.tableLayout_Top);
            this.splitContainer_Main.Panel2.Controls.Add(this.tableLayout_Bottom);

            // ════════════════════════════════════════════════════════════════════
            //  tableLayout_Top  (3 rows: url-bar | subproto | tabs)
            // ════════════════════════════════════════════════════════════════════
            this.tableLayout_Top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Top.ColumnCount = 1;
            this.tableLayout_Top.RowCount = 3;
            this.tableLayout_Top.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout_Top.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F)); // url row
            this.tableLayout_Top.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));  // subproto row
            this.tableLayout_Top.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));  // tabs
            this.tableLayout_Top.Padding = new System.Windows.Forms.Padding(8, 8, 8, 4);
            this.tableLayout_Top.Controls.Add(this.panel_UrlRow, 0, 0);
            this.tableLayout_Top.Controls.Add(this.panel_SubRow, 0, 1);
            this.tableLayout_Top.Controls.Add(this.tabControl_Left, 0, 2);

            // ── panel_UrlRow ──────────────────────────────────────────────────────
            this.panel_UrlRow.Dock = System.Windows.Forms.DockStyle.Fill;

            this.label_WsUrl.AutoSize = true;
            this.label_WsUrl.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.label_WsUrl.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.label_WsUrl.Location = new System.Drawing.Point(0, 0);
            this.label_WsUrl.Text = "WebSocket URL";
            this.panel_UrlRow.Controls.Add(this.label_WsUrl);

            this.textBox_WsUrl.Font = new System.Drawing.Font("Consolas", 10F);
            this.textBox_WsUrl.Location = new System.Drawing.Point(0, 20);
            this.textBox_WsUrl.Height = 28;
            this.textBox_WsUrl.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.panel_UrlRow.Controls.Add(this.textBox_WsUrl);

            // Connect (orange)
            this.button_Connect.BackColor = System.Drawing.Color.FromArgb(234, 88, 12);
            this.button_Connect.FlatAppearance.BorderSize = 0;
            this.button_Connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Connect.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button_Connect.ForeColor = System.Drawing.Color.White;
            this.button_Connect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Connect.Location = new System.Drawing.Point(0, 58);
            this.button_Connect.Size = new System.Drawing.Size(90, 34);
            this.button_Connect.Text = "▶ Connect";
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            this.panel_UrlRow.Controls.Add(this.button_Connect);

            // Disconnect (slate)
            this.button_Disconnect.BackColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.button_Disconnect.FlatAppearance.BorderSize = 0;
            this.button_Disconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Disconnect.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button_Disconnect.ForeColor = System.Drawing.Color.White;
            this.button_Disconnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Disconnect.Enabled = false;
            this.button_Disconnect.Location = new System.Drawing.Point(96, 58);
            this.button_Disconnect.Size = new System.Drawing.Size(106, 34);
            this.button_Disconnect.Text = "■ Disconnect";
            this.button_Disconnect.Click += new System.EventHandler(this.button_Disconnect_Click);
            this.panel_UrlRow.Controls.Add(this.button_Disconnect);

            // Test Connection (amber)
            this.button_TestConnection.BackColor = System.Drawing.Color.FromArgb(180, 83, 9);
            this.button_TestConnection.FlatAppearance.BorderSize = 0;
            this.button_TestConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_TestConnection.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button_TestConnection.ForeColor = System.Drawing.Color.White;
            this.button_TestConnection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_TestConnection.Location = new System.Drawing.Point(208, 58);
            this.button_TestConnection.Size = new System.Drawing.Size(134, 34);
            this.button_TestConnection.Text = "🔎 Test Connection";
            this.button_TestConnection.Click += new System.EventHandler(this.button_TestConnection_Click);
            this.panel_UrlRow.Controls.Add(this.button_TestConnection);

            // ── panel_SubRow ──────────────────────────────────────────────────────
            this.panel_SubRow.Dock = System.Windows.Forms.DockStyle.Fill;

            this.label_SubProto.AutoSize = true;
            this.label_SubProto.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.label_SubProto.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.label_SubProto.Location = new System.Drawing.Point(0, 0);
            this.label_SubProto.Text = "Subprotocol (optional)";
            this.panel_SubRow.Controls.Add(this.label_SubProto);

            this.textBox_SubProtocol.Font = new System.Drawing.Font("Consolas", 9.5F);
            this.textBox_SubProtocol.Location = new System.Drawing.Point(0, 18);
            this.textBox_SubProtocol.Size = new System.Drawing.Size(260, 26);
            this.panel_SubRow.Controls.Add(this.textBox_SubProtocol);

            // ════════════════════════════════════════════════════════════════════
            //  tabControl_Left  (Send / Fuzz / Headers)
            // ════════════════════════════════════════════════════════════════════
            this.tabControl_Left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Left.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabControl_Left.Controls.Add(this.tabPage_Message);
            this.tabControl_Left.Controls.Add(this.tabPage_Fuzz);
            this.tabControl_Left.Controls.Add(this.tabPage_Headers);

            // ── tabPage_Message (Send) ────────────────────────────────────────────
            this.tabPage_Message.Text = "📤  Send";
            this.tabPage_Message.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage_Message.Controls.Add(this.tableLayout_Send);

            this.tableLayout_Send.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Send.ColumnCount = 1;
            this.tableLayout_Send.RowCount = 3;
            this.tableLayout_Send.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout_Send.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));  // hint label
            this.tableLayout_Send.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F)); // editor
            this.tableLayout_Send.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F)); // bottom bar
            this.tableLayout_Send.Controls.Add(this.label_MsgHint, 0, 0);
            this.tableLayout_Send.Controls.Add(this.richTextBox_Message, 0, 1);
            this.tableLayout_Send.Controls.Add(this.panel_SendBottom, 0, 2);

            this.label_MsgHint.AutoSize = false;
            this.label_MsgHint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_MsgHint.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label_MsgHint.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.label_MsgHint.Text = "Message body — text, JSON, or hex bytes (when Binary is checked)  •  Ctrl+Enter to send";

            this.richTextBox_Message.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_Message.Font = new System.Drawing.Font("Consolas", 10F);
            this.richTextBox_Message.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox_Message.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.panel_SendBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_SendBottom.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            // Add Send first so DockStyle.Right reserves space, then checkbox fills left
            this.panel_SendBottom.Controls.Add(this.button_Send);
            this.panel_SendBottom.Controls.Add(this.checkBox_SendBinary);

            this.checkBox_SendBinary.AutoSize = true;
            this.checkBox_SendBinary.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkBox_SendBinary.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkBox_SendBinary.Text = "Send as Binary (hex)";

            this.button_Send.BackColor = System.Drawing.Color.FromArgb(234, 88, 12);
            this.button_Send.FlatAppearance.BorderSize = 0;
            this.button_Send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Send.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.button_Send.ForeColor = System.Drawing.Color.White;
            this.button_Send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Send.Enabled = false;
            this.button_Send.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_Send.Size = new System.Drawing.Size(160, 34);
            this.button_Send.Text = "📤  Send Message";
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);

            // ── tabPage_Fuzz ──────────────────────────────────────────────────────
            this.tabPage_Fuzz.Text = "🎯  Fuzz";
            this.tabPage_Fuzz.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage_Fuzz.Controls.Add(this.tableLayout_Fuzz);

            this.tableLayout_Fuzz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Fuzz.ColumnCount = 1;
            this.tableLayout_Fuzz.RowCount = 5;
            this.tableLayout_Fuzz.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout_Fuzz.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));  // hint
            this.tableLayout_Fuzz.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));  // wordlist
            this.tableLayout_Fuzz.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));  // delay
            this.tableLayout_Fuzz.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));  // start button
            this.tableLayout_Fuzz.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));  // spacer
            this.tableLayout_Fuzz.Controls.Add(this.label_FuzzHint, 0, 0);
            this.tableLayout_Fuzz.Controls.Add(this.panel_FuzzWordlistRow, 0, 1);
            this.tableLayout_Fuzz.Controls.Add(this.panel_FuzzDelayRow, 0, 2);
            this.tableLayout_Fuzz.Controls.Add(this.button_Fuzz, 0, 3);

            this.label_FuzzHint.AutoSize = false;
            this.label_FuzzHint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_FuzzHint.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label_FuzzHint.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.label_FuzzHint.Text = "Write the template in the Send tab. Use §FUZZ§ as the injection marker.\nLeave wordlist blank to use built-in payloads (XSS, SQLi, path traversal…)";

            // wordlist row
            this.panel_FuzzWordlistRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_FuzzWordlist.AutoSize = true;
            this.label_FuzzWordlist.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.label_FuzzWordlist.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.label_FuzzWordlist.Location = new System.Drawing.Point(0, 0);
            this.label_FuzzWordlist.Text = "Payload Wordlist (optional)";
            this.panel_FuzzWordlistRow.Controls.Add(this.label_FuzzWordlist);

            this.textBox_FuzzWordlist.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox_FuzzWordlist.Location = new System.Drawing.Point(0, 20);
            this.textBox_FuzzWordlist.Height = 26;
            this.textBox_FuzzWordlist.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.panel_FuzzWordlistRow.Controls.Add(this.textBox_FuzzWordlist);

            this.button_BrowseFuzzWordlist.BackColor = System.Drawing.Color.FromArgb(234, 88, 12);
            this.button_BrowseFuzzWordlist.FlatAppearance.BorderSize = 0;
            this.button_BrowseFuzzWordlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_BrowseFuzzWordlist.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.button_BrowseFuzzWordlist.ForeColor = System.Drawing.Color.White;
            this.button_BrowseFuzzWordlist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_BrowseFuzzWordlist.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.button_BrowseFuzzWordlist.Size = new System.Drawing.Size(80, 28);
            this.button_BrowseFuzzWordlist.Location = new System.Drawing.Point(340, 18);
            this.button_BrowseFuzzWordlist.Text = "Browse…";
            this.button_BrowseFuzzWordlist.Click += new System.EventHandler(this.button_BrowseFuzzWordlist_Click);
            this.panel_FuzzWordlistRow.Controls.Add(this.button_BrowseFuzzWordlist);

            // delay row
            this.panel_FuzzDelayRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_FuzzDelay.AutoSize = true;
            this.label_FuzzDelay.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.label_FuzzDelay.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.label_FuzzDelay.Location = new System.Drawing.Point(0, 0);
            this.label_FuzzDelay.Text = "Delay between payloads (ms)";
            this.panel_FuzzDelayRow.Controls.Add(this.label_FuzzDelay);

            this.numericUpDown_FuzzDelay.Location = new System.Drawing.Point(0, 20);
            this.numericUpDown_FuzzDelay.Size = new System.Drawing.Size(110, 26);
            this.numericUpDown_FuzzDelay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numericUpDown_FuzzDelay.Minimum = 0;
            this.numericUpDown_FuzzDelay.Maximum = 5000;
            this.numericUpDown_FuzzDelay.Value = 200;
            this.numericUpDown_FuzzDelay.Increment = 50;
            this.panel_FuzzDelayRow.Controls.Add(this.numericUpDown_FuzzDelay);

            this.button_Fuzz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Fuzz.BackColor = System.Drawing.Color.FromArgb(234, 88, 12);
            this.button_Fuzz.FlatAppearance.BorderSize = 0;
            this.button_Fuzz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Fuzz.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button_Fuzz.ForeColor = System.Drawing.Color.White;
            this.button_Fuzz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Fuzz.Enabled = false;
            this.button_Fuzz.Text = "🎯  Start Fuzz";
            this.button_Fuzz.Click += new System.EventHandler(this.button_Fuzz_Click);

            // ── tabPage_Headers ───────────────────────────────────────────────────
            this.tabPage_Headers.Text = "🔑  Headers";
            this.tabPage_Headers.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage_Headers.Controls.Add(this.dataGridView_Headers);

            this.dataGridView_Headers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Headers.AllowUserToAddRows = true;
            this.dataGridView_Headers.RowHeadersVisible = false;
            this.dataGridView_Headers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Headers.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dataGridView_Headers.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);

            this.col_WsHdrEnabled.HeaderText = "✓";
            this.col_WsHdrEnabled.FillWeight = 8;
            this.col_WsHdrEnabled.MinimumWidth = 28;
            this.col_WsHdrEnabled.TrueValue = true;
            this.col_WsHdrEnabled.FalseValue = false;

            this.col_WsHdrKey.HeaderText = "Header Name";
            this.col_WsHdrKey.Name = "col_WsHdrKey";
            this.col_WsHdrKey.FillWeight = 46;

            this.col_WsHdrValue.HeaderText = "Value";
            this.col_WsHdrValue.Name = "col_WsHdrValue";
            this.col_WsHdrValue.FillWeight = 46;

            this.dataGridView_Headers.Columns.Add(this.col_WsHdrEnabled);
            this.dataGridView_Headers.Columns.Add(this.col_WsHdrKey);
            this.dataGridView_Headers.Columns.Add(this.col_WsHdrValue);

            // ════════════════════════════════════════════════════════════════════
            //  BOTTOM panel — tableLayout_Bottom  (toolbar + grid)
            // ════════════════════════════════════════════════════════════════════
            this.tableLayout_Bottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Bottom.ColumnCount = 1;
            this.tableLayout_Bottom.RowCount = 2;
            this.tableLayout_Bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout_Bottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));  // toolbar
            this.tableLayout_Bottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F)); // grid
            this.tableLayout_Bottom.Controls.Add(this.panel_OutputBar, 0, 0);
            this.tableLayout_Bottom.Controls.Add(this.dataGridView_Output, 0, 1);

            // output toolbar
            this.panel_OutputBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_OutputBar.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.panel_OutputBar.Padding = new System.Windows.Forms.Padding(8, 4, 6, 4);
            // Add right-docked controls first, then left-docked label
            this.panel_OutputBar.Controls.Add(this.button_ClearOutput);
            this.panel_OutputBar.Controls.Add(this.button_SaveReport);
            this.panel_OutputBar.Controls.Add(this.progressBar_Scan);
            this.panel_OutputBar.Controls.Add(this.label_OutputTitle);

            this.label_OutputTitle.AutoSize = true;
            this.label_OutputTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label_OutputTitle.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.label_OutputTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_OutputTitle.Text = "  📋  MESSAGE LOG";
            this.label_OutputTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.progressBar_Scan.Dock = System.Windows.Forms.DockStyle.Left;
            this.progressBar_Scan.Width = 140;
            this.progressBar_Scan.Style = System.Windows.Forms.ProgressBarStyle.Blocks;

            this.button_ClearOutput.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.button_ClearOutput.FlatAppearance.BorderSize = 0;
            this.button_ClearOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ClearOutput.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.button_ClearOutput.ForeColor = System.Drawing.Color.White;
            this.button_ClearOutput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ClearOutput.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_ClearOutput.Width = 88;
            this.button_ClearOutput.Text = "🗑  Clear";
            this.button_ClearOutput.Click += new System.EventHandler(this.button_ClearOutput_Click);

            this.button_SaveReport.BackColor = System.Drawing.Color.FromArgb(234, 88, 12);
            this.button_SaveReport.FlatAppearance.BorderSize = 0;
            this.button_SaveReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SaveReport.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.button_SaveReport.ForeColor = System.Drawing.Color.White;
            this.button_SaveReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_SaveReport.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_SaveReport.Width = 110;
            this.button_SaveReport.Text = "💾  Save Report";
            this.button_SaveReport.Click += new System.EventHandler(this.button_SaveReport_Click);

            // ── dataGridView_Output ───────────────────────────────────────────────
            this.dataGridView_Output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Output.AllowUserToAddRows = false;
            this.dataGridView_Output.AllowUserToDeleteRows = false;
            this.dataGridView_Output.ReadOnly = true;
            this.dataGridView_Output.RowHeadersVisible = false;
            this.dataGridView_Output.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Output.MultiSelect = false;
            this.dataGridView_Output.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.None;
            this.dataGridView_Output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.dataGridView_Output.Font = new System.Drawing.Font("Consolas", 9F);
            this.dataGridView_Output.BackgroundColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.dataGridView_Output.GridColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.dataGridView_Output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            // Column header style
            this.dataGridView_Output.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.dataGridView_Output.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.dataGridView_Output.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.dataGridView_Output.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.dataGridView_Output.ColumnHeadersHeight = 28;
            this.dataGridView_Output.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            // Default row style
            this.dataGridView_Output.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.dataGridView_Output.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.dataGridView_Output.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(30, 58, 138);
            this.dataGridView_Output.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView_Output.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dataGridView_Output.RowTemplate.Height = 24;
            this.dataGridView_Output.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Output_CellDoubleClick);

            // Columns
            this.col_Num.HeaderText = "#";
            this.col_Num.Name = "col_Num";
            this.col_Num.Width = 48;
            this.col_Num.MinimumWidth = 40;
            this.col_Num.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.col_Num.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;

            this.col_Time.HeaderText = "Time";
            this.col_Time.Name = "col_Time";
            this.col_Time.Width = 100;
            this.col_Time.MinimumWidth = 90;
            this.col_Time.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);

            this.col_Direction.HeaderText = "Direction";
            this.col_Direction.Name = "col_Direction";
            this.col_Direction.Width = 90;
            this.col_Direction.MinimumWidth = 70;

            this.col_Type.HeaderText = "Type";
            this.col_Type.Name = "col_Type";
            this.col_Type.Width = 72;
            this.col_Type.MinimumWidth = 58;

            this.col_Status.HeaderText = "Status";
            this.col_Status.Name = "col_Status";
            this.col_Status.Width = 90;
            this.col_Status.MinimumWidth = 70;

            this.col_Size.HeaderText = "Size";
            this.col_Size.Name = "col_Size";
            this.col_Size.Width = 72;
            this.col_Size.MinimumWidth = 55;
            this.col_Size.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.col_Size.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);

            this.col_Data.HeaderText = "Data";
            this.col_Data.Name = "col_Data";
            this.col_Data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_Data.MinimumWidth = 120;
            this.col_Data.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;

            this.dataGridView_Output.Columns.Add(this.col_Num);
            this.dataGridView_Output.Columns.Add(this.col_Time);
            this.dataGridView_Output.Columns.Add(this.col_Direction);
            this.dataGridView_Output.Columns.Add(this.col_Type);
            this.dataGridView_Output.Columns.Add(this.col_Status);
            this.dataGridView_Output.Columns.Add(this.col_Size);
            this.dataGridView_Output.Columns.Add(this.col_Data);

            // ════════════════════════════════════════════════════════════════════
            //  Form
            // ════════════════════════════════════════════════════════════════════
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            this.ClientSize = new System.Drawing.Size(1100, 760);
            this.MinimumSize = new System.Drawing.Size(820, 600);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Controls.Add(this.splitContainer_Main);
            this.Controls.Add(this.panel_TopBar);
            this.Name = "WebSocketForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThreatScanner — WebSocket Tester";

            // ── ResumeLayout ──────────────────────────────────────────────────────
            this.panel_TopBar.ResumeLayout(false);
            this.panel_TopBar.PerformLayout();
            this.splitContainer_Main.ResumeLayout(false);
            this.tableLayout_Top.ResumeLayout(false);
            this.panel_UrlRow.ResumeLayout(false);
            this.panel_UrlRow.PerformLayout();
            this.panel_SubRow.ResumeLayout(false);
            this.panel_SubRow.PerformLayout();
            this.tabControl_Left.ResumeLayout(false);
            this.tabPage_Message.ResumeLayout(false);
            this.tableLayout_Send.ResumeLayout(false);
            this.panel_SendBottom.ResumeLayout(false);
            this.panel_SendBottom.PerformLayout();
            this.tabPage_Fuzz.ResumeLayout(false);
            this.tableLayout_Fuzz.ResumeLayout(false);
            this.panel_FuzzWordlistRow.ResumeLayout(false);
            this.panel_FuzzWordlistRow.PerformLayout();
            this.panel_FuzzDelayRow.ResumeLayout(false);
            this.panel_FuzzDelayRow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FuzzDelay)).EndInit();
            this.tabPage_Headers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Headers)).EndInit();
            this.tableLayout_Bottom.ResumeLayout(false);
            this.panel_OutputBar.ResumeLayout(false);
            this.panel_OutputBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Output)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        // ── Control declarations ──────────────────────────────────────────────────
        private System.Windows.Forms.Panel panel_TopBar;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_Subtitle;
        private System.Windows.Forms.SplitContainer splitContainer_Main;
        // TOP
        private System.Windows.Forms.TableLayoutPanel tableLayout_Top;
        private System.Windows.Forms.Panel panel_UrlRow;
        private System.Windows.Forms.Label label_WsUrl;
        private System.Windows.Forms.TextBox textBox_WsUrl;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.Button button_Disconnect;
        private System.Windows.Forms.Button button_TestConnection;
        private System.Windows.Forms.Panel panel_SubRow;
        private System.Windows.Forms.Label label_SubProto;
        private System.Windows.Forms.TextBox textBox_SubProtocol;
        private System.Windows.Forms.TabControl tabControl_Left;
        private System.Windows.Forms.TabPage tabPage_Message;
        private System.Windows.Forms.TableLayoutPanel tableLayout_Send;
        private System.Windows.Forms.Label label_MsgHint;
        private System.Windows.Forms.RichTextBox richTextBox_Message;
        private System.Windows.Forms.Panel panel_SendBottom;
        private System.Windows.Forms.CheckBox checkBox_SendBinary;
        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.TabPage tabPage_Fuzz;
        private System.Windows.Forms.TableLayoutPanel tableLayout_Fuzz;
        private System.Windows.Forms.Label label_FuzzHint;
        private System.Windows.Forms.Panel panel_FuzzWordlistRow;
        private System.Windows.Forms.Label label_FuzzWordlist;
        private System.Windows.Forms.TextBox textBox_FuzzWordlist;
        private System.Windows.Forms.Button button_BrowseFuzzWordlist;
        private System.Windows.Forms.Panel panel_FuzzDelayRow;
        private System.Windows.Forms.Label label_FuzzDelay;
        private System.Windows.Forms.NumericUpDown numericUpDown_FuzzDelay;
        private System.Windows.Forms.Button button_Fuzz;
        private System.Windows.Forms.TabPage tabPage_Headers;
        private System.Windows.Forms.DataGridView dataGridView_Headers;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_WsHdrEnabled;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_WsHdrKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_WsHdrValue;
        // BOTTOM
        private System.Windows.Forms.TableLayoutPanel tableLayout_Bottom;
        private System.Windows.Forms.Panel panel_OutputBar;
        private System.Windows.Forms.Label label_OutputTitle;
        private System.Windows.Forms.ProgressBar progressBar_Scan;
        private System.Windows.Forms.Button button_SaveReport;
        private System.Windows.Forms.Button button_ClearOutput;
        private System.Windows.Forms.DataGridView dataGridView_Output;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Direction;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Data;
    }
}