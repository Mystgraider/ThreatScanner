namespace ThreatScanner
{
    partial class AutoFillForm
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
            this.panel_TopBar = new System.Windows.Forms.Panel();
            this.label_AppTitle = new System.Windows.Forms.Label();
            this.label_AppSubtitle = new System.Windows.Forms.Label();
            this.button_SaveReport = new System.Windows.Forms.Button();
            this.button_ClearOutput = new System.Windows.Forms.Button();
            this.panel_RequestBar = new System.Windows.Forms.Panel();
            this.label_TargetUrl = new System.Windows.Forms.Label();
            this.textBox_TargetUrl = new System.Windows.Forms.TextBox();
            this.tabControl_AutoFill = new System.Windows.Forms.TabControl();
            this.tabPage_AutoDetect = new System.Windows.Forms.TabPage();
            this.dataGridView_Detected = new System.Windows.Forms.DataGridView();
            this.col_DetEnabled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_DetTag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DetId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DetType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DetLabel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DetSelector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DetValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_AutoDetectBar = new System.Windows.Forms.Panel();
            this.button_DetectFields = new System.Windows.Forms.Button();
            this.checkBox_HeadlessBrowser = new System.Windows.Forms.CheckBox();
            this.tabPage_Manual = new System.Windows.Forms.TabPage();
            this.dataGridView_Manual = new System.Windows.Forms.DataGridView();
            this.col_ManEnabled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_ManFieldType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.col_ManSelectorType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.col_ManSelectorValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ManValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ManNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_ManualBar = new System.Windows.Forms.Panel();
            this.button_AddRow = new System.Windows.Forms.Button();
            this.button_RemoveRow = new System.Windows.Forms.Button();
            this.label_ManualHint = new System.Windows.Forms.Label();
            this.panel_ActionBar = new System.Windows.Forms.Panel();
            this.button_FillForm = new System.Windows.Forms.Button();
            this.checkBox_DryRun = new System.Windows.Forms.CheckBox();
            this.label_DelayMs = new System.Windows.Forms.Label();
            this.numericUpDown_DelayMs = new System.Windows.Forms.NumericUpDown();
            this.panel_Output = new System.Windows.Forms.Panel();
            this.richTextBox_Output = new System.Windows.Forms.RichTextBox();
            this.label_Output = new System.Windows.Forms.Label();
            this.progressBar_Scan = new System.Windows.Forms.ProgressBar();
            this.panel_TopBar.SuspendLayout();
            this.panel_RequestBar.SuspendLayout();
            this.tabControl_AutoFill.SuspendLayout();
            this.tabPage_AutoDetect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Detected)).BeginInit();
            this.panel_AutoDetectBar.SuspendLayout();
            this.tabPage_Manual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Manual)).BeginInit();
            this.panel_ManualBar.SuspendLayout();
            this.panel_ActionBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DelayMs)).BeginInit();
            this.panel_Output.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_TopBar
            // 
            this.panel_TopBar.BackColor = System.Drawing.Color.White;
            this.panel_TopBar.Controls.Add(this.label_AppTitle);
            this.panel_TopBar.Controls.Add(this.label_AppSubtitle);
            this.panel_TopBar.Controls.Add(this.button_SaveReport);
            this.panel_TopBar.Controls.Add(this.button_ClearOutput);
            this.panel_TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_TopBar.Location = new System.Drawing.Point(0, 0);
            this.panel_TopBar.Name = "panel_TopBar";
            this.panel_TopBar.Size = new System.Drawing.Size(1280, 64);
            this.panel_TopBar.TabIndex = 0;
            // 
            // label_AppTitle
            // 
            this.label_AppTitle.AutoSize = true;
            this.label_AppTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label_AppTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.label_AppTitle.Location = new System.Drawing.Point(16, 12);
            this.label_AppTitle.Name = "label_AppTitle";
            this.label_AppTitle.Size = new System.Drawing.Size(158, 32);
            this.label_AppTitle.TabIndex = 0;
            this.label_AppTitle.Text = "📝  Auto Fill";
            // 
            // label_AppSubtitle
            // 
            this.label_AppSubtitle.AutoSize = true;
            this.label_AppSubtitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label_AppSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.label_AppSubtitle.Location = new System.Drawing.Point(18, 40);
            this.label_AppSubtitle.Name = "label_AppSubtitle";
            this.label_AppSubtitle.Size = new System.Drawing.Size(477, 20);
            this.label_AppSubtitle.TabIndex = 1;
            this.label_AppSubtitle.Text = "Detect & populate form fields on your own sites for QA / security testing";
            // 
            // button_SaveReport
            // 
            this.button_SaveReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_SaveReport.BackColor = System.Drawing.Color.White;
            this.button_SaveReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_SaveReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.button_SaveReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SaveReport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_SaveReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.button_SaveReport.Location = new System.Drawing.Point(1040, 16);
            this.button_SaveReport.Name = "button_SaveReport";
            this.button_SaveReport.Size = new System.Drawing.Size(110, 32);
            this.button_SaveReport.TabIndex = 2;
            this.button_SaveReport.Text = "💾 Save Log";
            this.button_SaveReport.UseVisualStyleBackColor = false;
            this.button_SaveReport.Click += new System.EventHandler(this.button_SaveReport_Click);
            // 
            // button_ClearOutput
            // 
            this.button_ClearOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ClearOutput.BackColor = System.Drawing.Color.White;
            this.button_ClearOutput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ClearOutput.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.button_ClearOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ClearOutput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_ClearOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.button_ClearOutput.Location = new System.Drawing.Point(1160, 16);
            this.button_ClearOutput.Name = "button_ClearOutput";
            this.button_ClearOutput.Size = new System.Drawing.Size(100, 32);
            this.button_ClearOutput.TabIndex = 3;
            this.button_ClearOutput.Text = "🧹 Clear";
            this.button_ClearOutput.UseVisualStyleBackColor = false;
            this.button_ClearOutput.Click += new System.EventHandler(this.button_ClearOutput_Click);
            // 
            // panel_RequestBar
            // 
            this.panel_RequestBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panel_RequestBar.Controls.Add(this.label_TargetUrl);
            this.panel_RequestBar.Controls.Add(this.textBox_TargetUrl);
            this.panel_RequestBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_RequestBar.Location = new System.Drawing.Point(0, 64);
            this.panel_RequestBar.Name = "panel_RequestBar";
            this.panel_RequestBar.Size = new System.Drawing.Size(1280, 56);
            this.panel_RequestBar.TabIndex = 1;
            // 
            // label_TargetUrl
            // 
            this.label_TargetUrl.AutoSize = true;
            this.label_TargetUrl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label_TargetUrl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.label_TargetUrl.Location = new System.Drawing.Point(16, 18);
            this.label_TargetUrl.Name = "label_TargetUrl";
            this.label_TargetUrl.Size = new System.Drawing.Size(99, 20);
            this.label_TargetUrl.TabIndex = 0;
            this.label_TargetUrl.Text = "TARGET URL";
            // 
            // textBox_TargetUrl
            // 
            this.textBox_TargetUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_TargetUrl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox_TargetUrl.Location = new System.Drawing.Point(115, 14);
            this.textBox_TargetUrl.Name = "textBox_TargetUrl";
            this.textBox_TargetUrl.Size = new System.Drawing.Size(1149, 30);
            this.textBox_TargetUrl.TabIndex = 1;
            // 
            // tabControl_AutoFill
            // 
            this.tabControl_AutoFill.Controls.Add(this.tabPage_AutoDetect);
            this.tabControl_AutoFill.Controls.Add(this.tabPage_Manual);
            this.tabControl_AutoFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_AutoFill.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.tabControl_AutoFill.Location = new System.Drawing.Point(0, 120);
            this.tabControl_AutoFill.Name = "tabControl_AutoFill";
            this.tabControl_AutoFill.SelectedIndex = 0;
            this.tabControl_AutoFill.Size = new System.Drawing.Size(1280, 680);
            this.tabControl_AutoFill.TabIndex = 2;
            // 
            // tabPage_AutoDetect
            // 
            this.tabPage_AutoDetect.BackColor = System.Drawing.Color.White;
            this.tabPage_AutoDetect.Controls.Add(this.dataGridView_Detected);
            this.tabPage_AutoDetect.Controls.Add(this.panel_AutoDetectBar);
            this.tabPage_AutoDetect.Location = new System.Drawing.Point(4, 30);
            this.tabPage_AutoDetect.Name = "tabPage_AutoDetect";
            this.tabPage_AutoDetect.Padding = new System.Windows.Forms.Padding(8);
            this.tabPage_AutoDetect.Size = new System.Drawing.Size(1272, 646);
            this.tabPage_AutoDetect.TabIndex = 0;
            this.tabPage_AutoDetect.Text = "Auto Detect";
            // 
            // dataGridView_Detected
            // 
            this.dataGridView_Detected.AllowUserToAddRows = false;
            this.dataGridView_Detected.AllowUserToDeleteRows = false;
            this.dataGridView_Detected.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Detected.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Detected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Detected.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_DetEnabled,
            this.col_DetTag,
            this.col_DetName,
            this.col_DetId,
            this.col_DetType,
            this.col_DetLabel,
            this.col_DetSelector,
            this.col_DetValue});
            this.dataGridView_Detected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Detected.Location = new System.Drawing.Point(8, 52);
            this.dataGridView_Detected.Name = "dataGridView_Detected";
            this.dataGridView_Detected.RowHeadersWidth = 24;
            this.dataGridView_Detected.Size = new System.Drawing.Size(1256, 586);
            this.dataGridView_Detected.TabIndex = 1;
            // 
            // col_DetEnabled
            // 
            this.col_DetEnabled.HeaderText = "✓";
            this.col_DetEnabled.MinimumWidth = 6;
            this.col_DetEnabled.Name = "col_DetEnabled";
            this.col_DetEnabled.Width = 30;
            // 
            // col_DetTag
            // 
            this.col_DetTag.HeaderText = "Tag";
            this.col_DetTag.MinimumWidth = 6;
            this.col_DetTag.Name = "col_DetTag";
            this.col_DetTag.ReadOnly = true;
            this.col_DetTag.Width = 70;
            // 
            // col_DetName
            // 
            this.col_DetName.HeaderText = "Name";
            this.col_DetName.MinimumWidth = 6;
            this.col_DetName.Name = "col_DetName";
            this.col_DetName.ReadOnly = true;
            this.col_DetName.Width = 150;
            // 
            // col_DetId
            // 
            this.col_DetId.HeaderText = "Id";
            this.col_DetId.MinimumWidth = 6;
            this.col_DetId.Name = "col_DetId";
            this.col_DetId.ReadOnly = true;
            this.col_DetId.Width = 150;
            // 
            // col_DetType
            // 
            this.col_DetType.HeaderText = "Type";
            this.col_DetType.MinimumWidth = 6;
            this.col_DetType.Name = "col_DetType";
            this.col_DetType.ReadOnly = true;
            this.col_DetType.Width = 90;
            // 
            // col_DetLabel
            // 
            this.col_DetLabel.HeaderText = "Label";
            this.col_DetLabel.MinimumWidth = 6;
            this.col_DetLabel.Name = "col_DetLabel";
            this.col_DetLabel.ReadOnly = true;
            this.col_DetLabel.Width = 150;
            // 
            // col_DetSelector
            // 
            this.col_DetSelector.HeaderText = "Selector (auto-built)";
            this.col_DetSelector.MinimumWidth = 6;
            this.col_DetSelector.Name = "col_DetSelector";
            this.col_DetSelector.ReadOnly = true;
            this.col_DetSelector.Width = 220;
            // 
            // col_DetValue
            // 
            this.col_DetValue.HeaderText = "Value to insert (editable)";
            this.col_DetValue.MinimumWidth = 6;
            this.col_DetValue.Name = "col_DetValue";
            this.col_DetValue.Width = 220;
            // 
            // panel_AutoDetectBar
            // 
            this.panel_AutoDetectBar.Controls.Add(this.button_DetectFields);
            this.panel_AutoDetectBar.Controls.Add(this.checkBox_HeadlessBrowser);
            this.panel_AutoDetectBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_AutoDetectBar.Location = new System.Drawing.Point(8, 8);
            this.panel_AutoDetectBar.Name = "panel_AutoDetectBar";
            this.panel_AutoDetectBar.Size = new System.Drawing.Size(1256, 44);
            this.panel_AutoDetectBar.TabIndex = 0;
            // 
            // button_DetectFields
            // 
            this.button_DetectFields.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.button_DetectFields.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_DetectFields.FlatAppearance.BorderSize = 0;
            this.button_DetectFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DetectFields.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.button_DetectFields.ForeColor = System.Drawing.Color.White;
            this.button_DetectFields.Location = new System.Drawing.Point(0, 6);
            this.button_DetectFields.Name = "button_DetectFields";
            this.button_DetectFields.Size = new System.Drawing.Size(180, 32);
            this.button_DetectFields.TabIndex = 0;
            this.button_DetectFields.Text = "🔎 Detect Fields";
            this.button_DetectFields.UseVisualStyleBackColor = false;
            this.button_DetectFields.Click += new System.EventHandler(this.button_DetectFields_Click);
            // 
            // checkBox_HeadlessBrowser
            // 
            this.checkBox_HeadlessBrowser.AutoSize = true;
            this.checkBox_HeadlessBrowser.Checked = true;
            this.checkBox_HeadlessBrowser.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_HeadlessBrowser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkBox_HeadlessBrowser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.checkBox_HeadlessBrowser.Location = new System.Drawing.Point(196, 11);
            this.checkBox_HeadlessBrowser.Name = "checkBox_HeadlessBrowser";
            this.checkBox_HeadlessBrowser.Size = new System.Drawing.Size(204, 24);
            this.checkBox_HeadlessBrowser.TabIndex = 1;
            this.checkBox_HeadlessBrowser.Text = "Run headless (no window)";
            this.checkBox_HeadlessBrowser.UseVisualStyleBackColor = true;
            // 
            // tabPage_Manual
            // 
            this.tabPage_Manual.BackColor = System.Drawing.Color.White;
            this.tabPage_Manual.Controls.Add(this.dataGridView_Manual);
            this.tabPage_Manual.Controls.Add(this.panel_ManualBar);
            this.tabPage_Manual.Location = new System.Drawing.Point(4, 30);
            this.tabPage_Manual.Name = "tabPage_Manual";
            this.tabPage_Manual.Padding = new System.Windows.Forms.Padding(8);
            this.tabPage_Manual.Size = new System.Drawing.Size(1272, 286);
            this.tabPage_Manual.TabIndex = 1;
            this.tabPage_Manual.Text = "Manual";
            // 
            // dataGridView_Manual
            // 
            this.dataGridView_Manual.AllowUserToAddRows = false;
            this.dataGridView_Manual.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Manual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Manual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Manual.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ManEnabled,
            this.col_ManFieldType,
            this.col_ManSelectorType,
            this.col_ManSelectorValue,
            this.col_ManValue,
            this.col_ManNotes});
            this.dataGridView_Manual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Manual.Location = new System.Drawing.Point(8, 52);
            this.dataGridView_Manual.Name = "dataGridView_Manual";
            this.dataGridView_Manual.RowHeadersWidth = 24;
            this.dataGridView_Manual.Size = new System.Drawing.Size(1256, 226);
            this.dataGridView_Manual.TabIndex = 1;
            // 
            // col_ManEnabled
            // 
            this.col_ManEnabled.HeaderText = "✓";
            this.col_ManEnabled.MinimumWidth = 6;
            this.col_ManEnabled.Name = "col_ManEnabled";
            this.col_ManEnabled.Width = 30;
            // 
            // col_ManFieldType
            // 
            this.col_ManFieldType.HeaderText = "Field Type";
            this.col_ManFieldType.Items.AddRange(new object[] {
            "text",
            "textarea",
            "select",
            "checkbox",
            "radio"});
            this.col_ManFieldType.MinimumWidth = 6;
            this.col_ManFieldType.Name = "col_ManFieldType";
            this.col_ManFieldType.Width = 110;
            // 
            // col_ManSelectorType
            // 
            this.col_ManSelectorType.HeaderText = "Selector Type";
            this.col_ManSelectorType.Items.AddRange(new object[] {
            "Name",
            "Id",
            "CSS Selector",
            "XPath"});
            this.col_ManSelectorType.MinimumWidth = 6;
            this.col_ManSelectorType.Name = "col_ManSelectorType";
            this.col_ManSelectorType.Width = 130;
            // 
            // col_ManSelectorValue
            // 
            this.col_ManSelectorValue.HeaderText = "Selector Value";
            this.col_ManSelectorValue.MinimumWidth = 6;
            this.col_ManSelectorValue.Name = "col_ManSelectorValue";
            this.col_ManSelectorValue.Width = 260;
            // 
            // col_ManValue
            // 
            this.col_ManValue.HeaderText = "Value to insert";
            this.col_ManValue.MinimumWidth = 6;
            this.col_ManValue.Name = "col_ManValue";
            this.col_ManValue.Width = 260;
            // 
            // col_ManNotes
            // 
            this.col_ManNotes.HeaderText = "Notes";
            this.col_ManNotes.MinimumWidth = 6;
            this.col_ManNotes.Name = "col_ManNotes";
            this.col_ManNotes.Width = 200;
            // 
            // panel_ManualBar
            // 
            this.panel_ManualBar.Controls.Add(this.button_AddRow);
            this.panel_ManualBar.Controls.Add(this.button_RemoveRow);
            this.panel_ManualBar.Controls.Add(this.label_ManualHint);
            this.panel_ManualBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ManualBar.Location = new System.Drawing.Point(8, 8);
            this.panel_ManualBar.Name = "panel_ManualBar";
            this.panel_ManualBar.Size = new System.Drawing.Size(1256, 44);
            this.panel_ManualBar.TabIndex = 0;
            // 
            // button_AddRow
            // 
            this.button_AddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.button_AddRow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_AddRow.FlatAppearance.BorderSize = 0;
            this.button_AddRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddRow.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.button_AddRow.ForeColor = System.Drawing.Color.White;
            this.button_AddRow.Location = new System.Drawing.Point(0, 6);
            this.button_AddRow.Name = "button_AddRow";
            this.button_AddRow.Size = new System.Drawing.Size(110, 32);
            this.button_AddRow.TabIndex = 0;
            this.button_AddRow.Text = "+ Add Row";
            this.button_AddRow.UseVisualStyleBackColor = false;
            this.button_AddRow.Click += new System.EventHandler(this.button_AddRow_Click);
            // 
            // button_RemoveRow
            // 
            this.button_RemoveRow.BackColor = System.Drawing.Color.White;
            this.button_RemoveRow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_RemoveRow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.button_RemoveRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_RemoveRow.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.button_RemoveRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.button_RemoveRow.Location = new System.Drawing.Point(118, 6);
            this.button_RemoveRow.Name = "button_RemoveRow";
            this.button_RemoveRow.Size = new System.Drawing.Size(130, 32);
            this.button_RemoveRow.TabIndex = 1;
            this.button_RemoveRow.Text = "🗑 Remove Selected";
            this.button_RemoveRow.UseVisualStyleBackColor = false;
            this.button_RemoveRow.Click += new System.EventHandler(this.button_RemoveRow_Click);
            // 
            // label_ManualHint
            // 
            this.label_ManualHint.AutoSize = true;
            this.label_ManualHint.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label_ManualHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.label_ManualHint.Location = new System.Drawing.Point(264, 14);
            this.label_ManualHint.Name = "label_ManualHint";
            this.label_ManualHint.Size = new System.Drawing.Size(697, 20);
            this.label_ManualHint.TabIndex = 2;
            this.label_ManualHint.Text = "Tip: prefer Name or Id selectors when available; use CSS Selector for anything el" +
    "se (e.g. [data-testid=...]).";
            // 
            // panel_ActionBar
            // 
            this.panel_ActionBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panel_ActionBar.Controls.Add(this.button_FillForm);
            this.panel_ActionBar.Controls.Add(this.checkBox_DryRun);
            this.panel_ActionBar.Controls.Add(this.label_DelayMs);
            this.panel_ActionBar.Controls.Add(this.numericUpDown_DelayMs);
            this.panel_ActionBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ActionBar.Location = new System.Drawing.Point(0, 120);
            this.panel_ActionBar.Name = "panel_ActionBar";
            this.panel_ActionBar.Size = new System.Drawing.Size(1280, 56);
            this.panel_ActionBar.TabIndex = 3;
            // 
            // button_FillForm
            // 
            this.button_FillForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.button_FillForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_FillForm.FlatAppearance.BorderSize = 0;
            this.button_FillForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_FillForm.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button_FillForm.ForeColor = System.Drawing.Color.White;
            this.button_FillForm.Location = new System.Drawing.Point(16, 10);
            this.button_FillForm.Name = "button_FillForm";
            this.button_FillForm.Size = new System.Drawing.Size(200, 36);
            this.button_FillForm.TabIndex = 0;
            this.button_FillForm.Text = "▶  Fill Form";
            this.button_FillForm.UseVisualStyleBackColor = false;
            this.button_FillForm.Click += new System.EventHandler(this.button_FillForm_Click);
            // 
            // checkBox_DryRun
            // 
            this.checkBox_DryRun.AutoSize = true;
            this.checkBox_DryRun.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkBox_DryRun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.checkBox_DryRun.Location = new System.Drawing.Point(232, 18);
            this.checkBox_DryRun.Name = "checkBox_DryRun";
            this.checkBox_DryRun.Size = new System.Drawing.Size(232, 24);
            this.checkBox_DryRun.TabIndex = 1;
            this.checkBox_DryRun.Text = "Dry run (fill only, don\'t submit)";
            this.checkBox_DryRun.UseVisualStyleBackColor = true;
            // 
            // label_DelayMs
            // 
            this.label_DelayMs.AutoSize = true;
            this.label_DelayMs.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label_DelayMs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.label_DelayMs.Location = new System.Drawing.Point(480, 18);
            this.label_DelayMs.Name = "label_DelayMs";
            this.label_DelayMs.Size = new System.Drawing.Size(184, 20);
            this.label_DelayMs.TabIndex = 2;
            this.label_DelayMs.Text = "Delay between fields (ms):";
            // 
            // numericUpDown_DelayMs
            // 
            this.numericUpDown_DelayMs.Location = new System.Drawing.Point(670, 16);
            this.numericUpDown_DelayMs.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDown_DelayMs.Name = "numericUpDown_DelayMs";
            this.numericUpDown_DelayMs.Size = new System.Drawing.Size(80, 27);
            this.numericUpDown_DelayMs.TabIndex = 3;
            this.numericUpDown_DelayMs.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // panel_Output
            // 
            this.panel_Output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.panel_Output.Controls.Add(this.richTextBox_Output);
            this.panel_Output.Controls.Add(this.label_Output);
            this.panel_Output.Controls.Add(this.progressBar_Scan);
            this.panel_Output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Output.Location = new System.Drawing.Point(0, 176);
            this.panel_Output.Name = "panel_Output";
            this.panel_Output.Padding = new System.Windows.Forms.Padding(12, 8, 12, 12);
            this.panel_Output.Size = new System.Drawing.Size(1280, 624);
            this.panel_Output.TabIndex = 4;
            // 
            // richTextBox_Output
            // 
            this.richTextBox_Output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.richTextBox_Output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_Output.DetectUrls = false;
            this.richTextBox_Output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_Output.Font = new System.Drawing.Font("Consolas", 9.5F);
            this.richTextBox_Output.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.richTextBox_Output.Location = new System.Drawing.Point(12, 28);
            this.richTextBox_Output.Name = "richTextBox_Output";
            this.richTextBox_Output.ReadOnly = true;
            this.richTextBox_Output.Size = new System.Drawing.Size(1256, 580);
            this.richTextBox_Output.TabIndex = 0;
            this.richTextBox_Output.Text = "";
            this.richTextBox_Output.WordWrap = false;
            // 
            // label_Output
            // 
            this.label_Output.AutoSize = true;
            this.label_Output.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Output.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label_Output.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.label_Output.Location = new System.Drawing.Point(12, 8);
            this.label_Output.Name = "label_Output";
            this.label_Output.Size = new System.Drawing.Size(69, 20);
            this.label_Output.TabIndex = 1;
            this.label_Output.Text = "OUTPUT";
            // 
            // progressBar_Scan
            // 
            this.progressBar_Scan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar_Scan.Location = new System.Drawing.Point(12, 608);
            this.progressBar_Scan.MarqueeAnimationSpeed = 30;
            this.progressBar_Scan.Name = "progressBar_Scan";
            this.progressBar_Scan.Size = new System.Drawing.Size(1256, 4);
            this.progressBar_Scan.TabIndex = 2;
            // 
            // AutoFillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 800);
            this.Controls.Add(this.panel_Output);
            this.Controls.Add(this.panel_ActionBar);
            this.Controls.Add(this.tabControl_AutoFill);
            this.Controls.Add(this.panel_RequestBar);
            this.Controls.Add(this.panel_TopBar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "AutoFillForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThreatScanner — Auto Fill";
            this.panel_TopBar.ResumeLayout(false);
            this.panel_TopBar.PerformLayout();
            this.panel_RequestBar.ResumeLayout(false);
            this.panel_RequestBar.PerformLayout();
            this.tabControl_AutoFill.ResumeLayout(false);
            this.tabPage_AutoDetect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Detected)).EndInit();
            this.panel_AutoDetectBar.ResumeLayout(false);
            this.panel_AutoDetectBar.PerformLayout();
            this.tabPage_Manual.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Manual)).EndInit();
            this.panel_ManualBar.ResumeLayout(false);
            this.panel_ManualBar.PerformLayout();
            this.panel_ActionBar.ResumeLayout(false);
            this.panel_ActionBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DelayMs)).EndInit();
            this.panel_Output.ResumeLayout(false);
            this.panel_Output.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        // TopBar
        private System.Windows.Forms.Panel panel_TopBar;
        private System.Windows.Forms.Label label_AppTitle;
        private System.Windows.Forms.Label label_AppSubtitle;
        private System.Windows.Forms.Button button_SaveReport;
        private System.Windows.Forms.Button button_ClearOutput;
        // RequestBar
        private System.Windows.Forms.Panel panel_RequestBar;
        private System.Windows.Forms.Label label_TargetUrl;
        private System.Windows.Forms.TextBox textBox_TargetUrl;
        // Tabs
        private System.Windows.Forms.TabControl tabControl_AutoFill;
        // Auto Detect
        private System.Windows.Forms.TabPage tabPage_AutoDetect;
        private System.Windows.Forms.Panel panel_AutoDetectBar;
        private System.Windows.Forms.Button button_DetectFields;
        private System.Windows.Forms.CheckBox checkBox_HeadlessBrowser;
        private System.Windows.Forms.DataGridView dataGridView_Detected;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_DetEnabled;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DetTag;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DetId;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DetType;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DetLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DetSelector;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DetValue;
        // Manual
        private System.Windows.Forms.TabPage tabPage_Manual;
        private System.Windows.Forms.Panel panel_ManualBar;
        private System.Windows.Forms.Button button_AddRow;
        private System.Windows.Forms.Button button_RemoveRow;
        private System.Windows.Forms.Label label_ManualHint;
        private System.Windows.Forms.DataGridView dataGridView_Manual;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_ManEnabled;
        private System.Windows.Forms.DataGridViewComboBoxColumn col_ManFieldType;
        private System.Windows.Forms.DataGridViewComboBoxColumn col_ManSelectorType;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ManSelectorValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ManValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ManNotes;
        // Action bar
        private System.Windows.Forms.Panel panel_ActionBar;
        private System.Windows.Forms.Button button_FillForm;
        private System.Windows.Forms.CheckBox checkBox_DryRun;
        private System.Windows.Forms.Label label_DelayMs;
        private System.Windows.Forms.NumericUpDown numericUpDown_DelayMs;
        // Output
        private System.Windows.Forms.Panel panel_Output;
        private System.Windows.Forms.Label label_Output;
        private System.Windows.Forms.RichTextBox richTextBox_Output;
        private System.Windows.Forms.ProgressBar progressBar_Scan;
    }
}