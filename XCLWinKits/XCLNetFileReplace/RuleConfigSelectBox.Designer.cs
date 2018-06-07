namespace XCLNetFileReplace
{
    partial class RuleConfigSelectBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RuleConfigSelectBox));
            this.dataGridRuleConfig = new System.Windows.Forms.DataGridView();
            this.grid_RuleConfigID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_OldContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_NewContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_IsRegex_Text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_IsIgnoreCase_Text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_IsWholeMatch_Text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_IsFileName_Text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_IsFileContent_Text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_CreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_UpdateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSelectAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnSelectNone = new DevExpress.XtraEditors.SimpleButton();
            this.btnSelectInverse = new DevExpress.XtraEditors.SimpleButton();
            this.btnSelectOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewContent = new System.Windows.Forms.TextBox();
            this.ckIsRegex = new System.Windows.Forms.CheckBox();
            this.ckIsFileContent = new System.Windows.Forms.CheckBox();
            this.ckIsIgnoreCase = new System.Windows.Forms.CheckBox();
            this.ckIsFileName = new System.Windows.Forms.CheckBox();
            this.ckIsWholeMatch = new System.Windows.Forms.CheckBox();
            this.txtOldContent = new System.Windows.Forms.TextBox();
            this.txtRuleID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRuleName = new System.Windows.Forms.TextBox();
            this.btnInput = new DevExpress.XtraEditors.SimpleButton();
            this.btnRuleOutput = new DevExpress.XtraEditors.SimpleButton();
            this.tabRuleConfig = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabPageAdd = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tabPageSelectRule = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRuleConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabRuleConfig)).BeginInit();
            this.tabRuleConfig.SuspendLayout();
            this.tabPageAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.tabPageSelectRule.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridRuleConfig
            // 
            this.dataGridRuleConfig.AllowUserToAddRows = false;
            this.dataGridRuleConfig.AllowUserToDeleteRows = false;
            this.dataGridRuleConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridRuleConfig.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridRuleConfig.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridRuleConfig.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridRuleConfig.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridRuleConfig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRuleConfig.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grid_RuleConfigID,
            this.grid_Name,
            this.grid_OldContent,
            this.grid_NewContent,
            this.grid_IsRegex_Text,
            this.grid_IsIgnoreCase_Text,
            this.grid_IsWholeMatch_Text,
            this.grid_IsFileName_Text,
            this.grid_IsFileContent_Text,
            this.grid_CreateTime,
            this.grid_UpdateTime});
            this.dataGridRuleConfig.Location = new System.Drawing.Point(4, 5);
            this.dataGridRuleConfig.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridRuleConfig.Name = "dataGridRuleConfig";
            this.dataGridRuleConfig.ReadOnly = true;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridRuleConfig.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridRuleConfig.RowTemplate.Height = 23;
            this.dataGridRuleConfig.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridRuleConfig.Size = new System.Drawing.Size(1214, 480);
            this.dataGridRuleConfig.TabIndex = 1;
            this.dataGridRuleConfig.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridRuleConfig_DataBindingComplete);
            this.dataGridRuleConfig.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridRuleConfig_RowPostPaint);
            // 
            // grid_RuleConfigID
            // 
            this.grid_RuleConfigID.DataPropertyName = "RuleConfigID";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grid_RuleConfigID.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid_RuleConfigID.HeaderText = "ID";
            this.grid_RuleConfigID.Name = "grid_RuleConfigID";
            this.grid_RuleConfigID.ReadOnly = true;
            this.grid_RuleConfigID.Visible = false;
            // 
            // grid_Name
            // 
            this.grid_Name.DataPropertyName = "Name";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grid_Name.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_Name.HeaderText = "名称";
            this.grid_Name.Name = "grid_Name";
            this.grid_Name.ReadOnly = true;
            // 
            // grid_OldContent
            // 
            this.grid_OldContent.DataPropertyName = "OldContent";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grid_OldContent.DefaultCellStyle = dataGridViewCellStyle4;
            this.grid_OldContent.HeaderText = "查找内容";
            this.grid_OldContent.Name = "grid_OldContent";
            this.grid_OldContent.ReadOnly = true;
            // 
            // grid_NewContent
            // 
            this.grid_NewContent.DataPropertyName = "NewContent";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grid_NewContent.DefaultCellStyle = dataGridViewCellStyle5;
            this.grid_NewContent.HeaderText = "替换内容";
            this.grid_NewContent.Name = "grid_NewContent";
            this.grid_NewContent.ReadOnly = true;
            // 
            // grid_IsRegex_Text
            // 
            this.grid_IsRegex_Text.DataPropertyName = "IsRegex_Text";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grid_IsRegex_Text.DefaultCellStyle = dataGridViewCellStyle6;
            this.grid_IsRegex_Text.HeaderText = "是否为正则表达式";
            this.grid_IsRegex_Text.Name = "grid_IsRegex_Text";
            this.grid_IsRegex_Text.ReadOnly = true;
            this.grid_IsRegex_Text.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // grid_IsIgnoreCase_Text
            // 
            this.grid_IsIgnoreCase_Text.DataPropertyName = "IsIgnoreCase_Text";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grid_IsIgnoreCase_Text.DefaultCellStyle = dataGridViewCellStyle7;
            this.grid_IsIgnoreCase_Text.HeaderText = "是否区分大小写";
            this.grid_IsIgnoreCase_Text.Name = "grid_IsIgnoreCase_Text";
            this.grid_IsIgnoreCase_Text.ReadOnly = true;
            this.grid_IsIgnoreCase_Text.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // grid_IsWholeMatch_Text
            // 
            this.grid_IsWholeMatch_Text.DataPropertyName = "IsWholeMatch_Text";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grid_IsWholeMatch_Text.DefaultCellStyle = dataGridViewCellStyle8;
            this.grid_IsWholeMatch_Text.HeaderText = "是否整字匹配";
            this.grid_IsWholeMatch_Text.Name = "grid_IsWholeMatch_Text";
            this.grid_IsWholeMatch_Text.ReadOnly = true;
            this.grid_IsWholeMatch_Text.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // grid_IsFileName_Text
            // 
            this.grid_IsFileName_Text.DataPropertyName = "IsFileName_Text";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grid_IsFileName_Text.DefaultCellStyle = dataGridViewCellStyle9;
            this.grid_IsFileName_Text.HeaderText = "是否匹配文件名";
            this.grid_IsFileName_Text.Name = "grid_IsFileName_Text";
            this.grid_IsFileName_Text.ReadOnly = true;
            this.grid_IsFileName_Text.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // grid_IsFileContent_Text
            // 
            this.grid_IsFileContent_Text.DataPropertyName = "IsFileContent_Text";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grid_IsFileContent_Text.DefaultCellStyle = dataGridViewCellStyle10;
            this.grid_IsFileContent_Text.HeaderText = "是否匹配文件内容";
            this.grid_IsFileContent_Text.Name = "grid_IsFileContent_Text";
            this.grid_IsFileContent_Text.ReadOnly = true;
            this.grid_IsFileContent_Text.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // grid_CreateTime
            // 
            this.grid_CreateTime.DataPropertyName = "CreateTime";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grid_CreateTime.DefaultCellStyle = dataGridViewCellStyle11;
            this.grid_CreateTime.HeaderText = "创建时间";
            this.grid_CreateTime.Name = "grid_CreateTime";
            this.grid_CreateTime.ReadOnly = true;
            // 
            // grid_UpdateTime
            // 
            this.grid_UpdateTime.DataPropertyName = "UpdateTime";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grid_UpdateTime.DefaultCellStyle = dataGridViewCellStyle12;
            this.grid_UpdateTime.HeaderText = "更新时间";
            this.grid_UpdateTime.Name = "grid_UpdateTime";
            this.grid_UpdateTime.ReadOnly = true;
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectAll.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectAll.ImageOptions.Image")));
            this.btnSelectAll.Location = new System.Drawing.Point(790, 531);
            this.btnSelectAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(100, 35);
            this.btnSelectAll.TabIndex = 3;
            this.btnSelectAll.Text = "全选";
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnSelectNone
            // 
            this.btnSelectNone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectNone.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectNone.ImageOptions.Image")));
            this.btnSelectNone.Location = new System.Drawing.Point(1006, 531);
            this.btnSelectNone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelectNone.Name = "btnSelectNone";
            this.btnSelectNone.Size = new System.Drawing.Size(100, 35);
            this.btnSelectNone.TabIndex = 4;
            this.btnSelectNone.Text = "全不选";
            this.btnSelectNone.Click += new System.EventHandler(this.btnSelectNone_Click);
            // 
            // btnSelectInverse
            // 
            this.btnSelectInverse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectInverse.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectInverse.ImageOptions.Image")));
            this.btnSelectInverse.Location = new System.Drawing.Point(898, 531);
            this.btnSelectInverse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelectInverse.Name = "btnSelectInverse";
            this.btnSelectInverse.Size = new System.Drawing.Size(100, 35);
            this.btnSelectInverse.TabIndex = 5;
            this.btnSelectInverse.Text = "反选";
            this.btnSelectInverse.Click += new System.EventHandler(this.btnSelectInverse_Click);
            // 
            // btnSelectOK
            // 
            this.btnSelectOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectOK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectOK.ImageOptions.Image")));
            this.btnSelectOK.Location = new System.Drawing.Point(1114, 531);
            this.btnSelectOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelectOK.Name = "btnSelectOK";
            this.btnSelectOK.Size = new System.Drawing.Size(100, 35);
            this.btnSelectOK.TabIndex = 6;
            this.btnSelectOK.Text = "选好了";
            this.btnSelectOK.Click += new System.EventHandler(this.btnSelectOK_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.Location = new System.Drawing.Point(4, 531);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 35);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "添加新规则";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(132, 531);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 35);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "修改规则";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.ImageOptions.Image")));
            this.btnDel.Location = new System.Drawing.Point(260, 531);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(120, 35);
            this.btnDel.TabIndex = 9;
            this.btnDel.Text = "删除规则";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(1084, 510);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 47);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保存规则";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "规则ID：";
            // 
            // txtNewContent
            // 
            this.txtNewContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNewContent.Location = new System.Drawing.Point(2, 26);
            this.txtNewContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNewContent.Multiline = true;
            this.txtNewContent.Name = "txtNewContent";
            this.txtNewContent.Size = new System.Drawing.Size(1208, 186);
            this.txtNewContent.TabIndex = 0;
            // 
            // ckIsRegex
            // 
            this.ckIsRegex.AutoSize = true;
            this.ckIsRegex.Location = new System.Drawing.Point(10, 159);
            this.ckIsRegex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ckIsRegex.Name = "ckIsRegex";
            this.ckIsRegex.Size = new System.Drawing.Size(105, 22);
            this.ckIsRegex.TabIndex = 12;
            this.ckIsRegex.Text = "正则表达式";
            this.ckIsRegex.UseVisualStyleBackColor = true;
            this.ckIsRegex.CheckedChanged += new System.EventHandler(this.ckIsRegex_CheckedChanged);
            // 
            // ckIsFileContent
            // 
            this.ckIsFileContent.AutoSize = true;
            this.ckIsFileContent.Location = new System.Drawing.Point(492, 159);
            this.ckIsFileContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ckIsFileContent.Name = "ckIsFileContent";
            this.ckIsFileContent.Size = new System.Drawing.Size(90, 22);
            this.ckIsFileContent.TabIndex = 16;
            this.ckIsFileContent.Text = "文件内容";
            this.ckIsFileContent.UseVisualStyleBackColor = true;
            this.ckIsFileContent.CheckedChanged += new System.EventHandler(this.ckIsFileContent_CheckedChanged);
            // 
            // ckIsIgnoreCase
            // 
            this.ckIsIgnoreCase.AutoSize = true;
            this.ckIsIgnoreCase.Location = new System.Drawing.Point(132, 159);
            this.ckIsIgnoreCase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ckIsIgnoreCase.Name = "ckIsIgnoreCase";
            this.ckIsIgnoreCase.Size = new System.Drawing.Size(105, 22);
            this.ckIsIgnoreCase.TabIndex = 13;
            this.ckIsIgnoreCase.Text = "忽略大小写";
            this.ckIsIgnoreCase.UseVisualStyleBackColor = true;
            // 
            // ckIsFileName
            // 
            this.ckIsFileName.AutoSize = true;
            this.ckIsFileName.Location = new System.Drawing.Point(370, 159);
            this.ckIsFileName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ckIsFileName.Name = "ckIsFileName";
            this.ckIsFileName.Size = new System.Drawing.Size(75, 22);
            this.ckIsFileName.TabIndex = 15;
            this.ckIsFileName.Text = "文件名";
            this.ckIsFileName.UseVisualStyleBackColor = true;
            this.ckIsFileName.CheckedChanged += new System.EventHandler(this.ckIsFileName_CheckedChanged);
            // 
            // ckIsWholeMatch
            // 
            this.ckIsWholeMatch.AutoSize = true;
            this.ckIsWholeMatch.Location = new System.Drawing.Point(253, 159);
            this.ckIsWholeMatch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ckIsWholeMatch.Name = "ckIsWholeMatch";
            this.ckIsWholeMatch.Size = new System.Drawing.Size(90, 22);
            this.ckIsWholeMatch.TabIndex = 14;
            this.ckIsWholeMatch.Text = "整字匹配";
            this.ckIsWholeMatch.UseVisualStyleBackColor = true;
            this.ckIsWholeMatch.CheckedChanged += new System.EventHandler(this.ckIsWholeMatch_CheckedChanged);
            // 
            // txtOldContent
            // 
            this.txtOldContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOldContent.Location = new System.Drawing.Point(2, 22);
            this.txtOldContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOldContent.Multiline = true;
            this.txtOldContent.Name = "txtOldContent";
            this.txtOldContent.Size = new System.Drawing.Size(1208, 127);
            this.txtOldContent.TabIndex = 0;
            // 
            // txtRuleID
            // 
            this.txtRuleID.Enabled = false;
            this.txtRuleID.Location = new System.Drawing.Point(433, 20);
            this.txtRuleID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRuleID.Name = "txtRuleID";
            this.txtRuleID.Size = new System.Drawing.Size(132, 26);
            this.txtRuleID.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "规则名：";
            // 
            // txtRuleName
            // 
            this.txtRuleName.Location = new System.Drawing.Point(92, 20);
            this.txtRuleName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRuleName.Name = "txtRuleName";
            this.txtRuleName.Size = new System.Drawing.Size(220, 26);
            this.txtRuleName.TabIndex = 4;
            // 
            // btnInput
            // 
            this.btnInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnInput.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInput.ImageOptions.Image")));
            this.btnInput.Location = new System.Drawing.Point(516, 531);
            this.btnInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(120, 35);
            this.btnInput.TabIndex = 11;
            this.btnInput.Text = "导入规则";
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnRuleOutput
            // 
            this.btnRuleOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRuleOutput.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRuleOutput.ImageOptions.Image")));
            this.btnRuleOutput.Location = new System.Drawing.Point(388, 531);
            this.btnRuleOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRuleOutput.Name = "btnRuleOutput";
            this.btnRuleOutput.Size = new System.Drawing.Size(120, 35);
            this.btnRuleOutput.TabIndex = 10;
            this.btnRuleOutput.Text = "导出规则";
            this.btnRuleOutput.Click += new System.EventHandler(this.btnRuleOutput_Click);
            // 
            // tabRuleConfig
            // 
            this.tabRuleConfig.Controls.Add(this.tabPageAdd);
            this.tabRuleConfig.Controls.Add(this.tabPageSelectRule);
            this.tabRuleConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabRuleConfig.Location = new System.Drawing.Point(0, 0);
            this.tabRuleConfig.Name = "tabRuleConfig";
            this.tabRuleConfig.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabPageSelectRule,
            this.tabPageAdd});
            this.tabRuleConfig.RegularSize = new System.Drawing.Size(1240, 645);
            this.tabRuleConfig.SelectedPage = this.tabPageSelectRule;
            this.tabRuleConfig.ShowToolTips = DevExpress.Utils.DefaultBoolean.False;
            this.tabRuleConfig.Size = new System.Drawing.Size(1240, 645);
            this.tabRuleConfig.TabIndex = 11;
            this.tabRuleConfig.Text = "tabPane1";
            // 
            // tabPageAdd
            // 
            this.tabPageAdd.Caption = "添加或修改规则";
            this.tabPageAdd.Controls.Add(this.groupControl2);
            this.tabPageAdd.Controls.Add(this.groupControl1);
            this.tabPageAdd.Controls.Add(this.btnSave);
            this.tabPageAdd.Controls.Add(this.label2);
            this.tabPageAdd.Controls.Add(this.label1);
            this.tabPageAdd.Controls.Add(this.txtRuleName);
            this.tabPageAdd.Controls.Add(this.txtRuleID);
            this.tabPageAdd.Name = "tabPageAdd";
            this.tabPageAdd.Size = new System.Drawing.Size(1218, 586);
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.txtNewContent);
            this.groupControl2.Location = new System.Drawing.Point(3, 273);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1212, 214);
            this.groupControl2.TabIndex = 9;
            this.groupControl2.Text = "替换内容：";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.ckIsRegex);
            this.groupControl1.Controls.Add(this.ckIsFileContent);
            this.groupControl1.Controls.Add(this.txtOldContent);
            this.groupControl1.Controls.Add(this.ckIsIgnoreCase);
            this.groupControl1.Controls.Add(this.ckIsWholeMatch);
            this.groupControl1.Controls.Add(this.ckIsFileName);
            this.groupControl1.Location = new System.Drawing.Point(3, 74);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1210, 193);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "查找内容：";
            // 
            // tabPageSelectRule
            // 
            this.tabPageSelectRule.Caption = "选择规则";
            this.tabPageSelectRule.Controls.Add(this.label3);
            this.tabPageSelectRule.Controls.Add(this.btnInput);
            this.tabPageSelectRule.Controls.Add(this.dataGridRuleConfig);
            this.tabPageSelectRule.Controls.Add(this.btnRuleOutput);
            this.tabPageSelectRule.Controls.Add(this.btnUpdate);
            this.tabPageSelectRule.Controls.Add(this.btnDel);
            this.tabPageSelectRule.Controls.Add(this.btnSelectInverse);
            this.tabPageSelectRule.Controls.Add(this.btnSelectOK);
            this.tabPageSelectRule.Controls.Add(this.btnSelectAll);
            this.tabPageSelectRule.Controls.Add(this.btnSelectNone);
            this.tabPageSelectRule.Controls.Add(this.btnAdd);
            this.tabPageSelectRule.Name = "tabPageSelectRule";
            this.tabPageSelectRule.Size = new System.Drawing.Size(1218, 586);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(14, 499);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "说明：按Ctrl键可多选！";
            // 
            // RuleConfigSelectBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 645);
            this.Controls.Add(this.tabRuleConfig);
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1255, 691);
            this.Name = "RuleConfigSelectBox";
            this.Text = "RuleConfigSelectBox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RuleConfigSelectBox_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRuleConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabRuleConfig)).EndInit();
            this.tabRuleConfig.ResumeLayout(false);
            this.tabPageAdd.ResumeLayout(false);
            this.tabPageAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.tabPageSelectRule.ResumeLayout(false);
            this.tabPageSelectRule.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridRuleConfig;
        private DevExpress.XtraEditors.SimpleButton btnSelectAll;
        private DevExpress.XtraEditors.SimpleButton btnSelectNone;
        private DevExpress.XtraEditors.SimpleButton btnSelectInverse;
        private DevExpress.XtraEditors.SimpleButton btnSelectOK;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_RuleConfigID;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_OldContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_NewContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_IsRegex_Text;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_IsIgnoreCase_Text;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_IsWholeMatch_Text;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_IsFileName_Text;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_IsFileContent_Text;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_CreateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_UpdateTime;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnDel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRuleID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRuleName;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.TextBox txtNewContent;
        private System.Windows.Forms.CheckBox ckIsFileContent;
        private System.Windows.Forms.CheckBox ckIsFileName;
        private System.Windows.Forms.CheckBox ckIsWholeMatch;
        private System.Windows.Forms.CheckBox ckIsIgnoreCase;
        private System.Windows.Forms.CheckBox ckIsRegex;
        private System.Windows.Forms.TextBox txtOldContent;
        private DevExpress.XtraEditors.SimpleButton btnRuleOutput;
        private DevExpress.XtraEditors.SimpleButton btnInput;
        private DevExpress.XtraBars.Navigation.TabPane tabRuleConfig;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabPageAdd;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabPageSelectRule;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Label label3;
    }
}