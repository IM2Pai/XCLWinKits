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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnSelectNone = new System.Windows.Forms.Button();
            this.btnSelectInverse = new System.Windows.Forms.Button();
            this.btnSelectOK = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.tabRuleConfig = new System.Windows.Forms.TabControl();
            this.tabPageAdd = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtNewContent = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ckIsFileContent = new System.Windows.Forms.CheckBox();
            this.ckIsFileName = new System.Windows.Forms.CheckBox();
            this.ckIsWholeMatch = new System.Windows.Forms.CheckBox();
            this.ckIsIgnoreCase = new System.Windows.Forms.CheckBox();
            this.ckIsRegex = new System.Windows.Forms.CheckBox();
            this.txtOldContent = new System.Windows.Forms.TextBox();
            this.txtRuleID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRuleName = new System.Windows.Forms.TextBox();
            this.tabPageSelectRule = new System.Windows.Forms.TabPage();
            this.btnInput = new System.Windows.Forms.Button();
            this.btnRuleOutput = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRuleConfig)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.tabRuleConfig.SuspendLayout();
            this.tabPageAdd.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            this.dataGridRuleConfig.Location = new System.Drawing.Point(4, 8);
            this.dataGridRuleConfig.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridRuleConfig.Name = "dataGridRuleConfig";
            this.dataGridRuleConfig.ReadOnly = true;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridRuleConfig.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridRuleConfig.RowTemplate.Height = 23;
            this.dataGridRuleConfig.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridRuleConfig.Size = new System.Drawing.Size(1217, 545);
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
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 629);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1240, 25);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(200, 20);
            this.toolStripStatusLabel1.Text = "说明：按Ctrl键可进行多选！";
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectAll.Location = new System.Drawing.Point(791, 561);
            this.btnSelectAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(100, 29);
            this.btnSelectAll.TabIndex = 3;
            this.btnSelectAll.Text = "全选";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnSelectNone
            // 
            this.btnSelectNone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectNone.Location = new System.Drawing.Point(1007, 561);
            this.btnSelectNone.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectNone.Name = "btnSelectNone";
            this.btnSelectNone.Size = new System.Drawing.Size(100, 29);
            this.btnSelectNone.TabIndex = 4;
            this.btnSelectNone.Text = "全不选";
            this.btnSelectNone.UseVisualStyleBackColor = true;
            this.btnSelectNone.Click += new System.EventHandler(this.btnSelectNone_Click);
            // 
            // btnSelectInverse
            // 
            this.btnSelectInverse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectInverse.Location = new System.Drawing.Point(899, 561);
            this.btnSelectInverse.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectInverse.Name = "btnSelectInverse";
            this.btnSelectInverse.Size = new System.Drawing.Size(100, 29);
            this.btnSelectInverse.TabIndex = 5;
            this.btnSelectInverse.Text = "反选";
            this.btnSelectInverse.UseVisualStyleBackColor = true;
            this.btnSelectInverse.Click += new System.EventHandler(this.btnSelectInverse_Click);
            // 
            // btnSelectOK
            // 
            this.btnSelectOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectOK.Location = new System.Drawing.Point(1115, 561);
            this.btnSelectOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectOK.Name = "btnSelectOK";
            this.btnSelectOK.Size = new System.Drawing.Size(100, 29);
            this.btnSelectOK.TabIndex = 6;
            this.btnSelectOK.Text = "选好了";
            this.btnSelectOK.UseVisualStyleBackColor = true;
            this.btnSelectOK.Click += new System.EventHandler(this.btnSelectOK_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Location = new System.Drawing.Point(11, 561);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 29);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "添加新规则";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdate.Location = new System.Drawing.Point(119, 561);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 29);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "修改规则";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDel.Location = new System.Drawing.Point(227, 561);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(100, 29);
            this.btnDel.TabIndex = 9;
            this.btnDel.Text = "删除规则";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // tabRuleConfig
            // 
            this.tabRuleConfig.Controls.Add(this.tabPageAdd);
            this.tabRuleConfig.Controls.Add(this.tabPageSelectRule);
            this.tabRuleConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabRuleConfig.Location = new System.Drawing.Point(0, 0);
            this.tabRuleConfig.Margin = new System.Windows.Forms.Padding(4);
            this.tabRuleConfig.Name = "tabRuleConfig";
            this.tabRuleConfig.SelectedIndex = 0;
            this.tabRuleConfig.Size = new System.Drawing.Size(1240, 629);
            this.tabRuleConfig.TabIndex = 10;
            // 
            // tabPageAdd
            // 
            this.tabPageAdd.Controls.Add(this.btnSave);
            this.tabPageAdd.Controls.Add(this.label2);
            this.tabPageAdd.Controls.Add(this.groupBox4);
            this.tabPageAdd.Controls.Add(this.groupBox3);
            this.tabPageAdd.Controls.Add(this.txtRuleID);
            this.tabPageAdd.Controls.Add(this.label1);
            this.tabPageAdd.Controls.Add(this.txtRuleName);
            this.tabPageAdd.Location = new System.Drawing.Point(4, 25);
            this.tabPageAdd.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageAdd.Name = "tabPageAdd";
            this.tabPageAdd.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageAdd.Size = new System.Drawing.Size(1232, 600);
            this.tabPageAdd.TabIndex = 1;
            this.tabPageAdd.Text = "添加或修改规则";
            this.tabPageAdd.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(1085, 539);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 39);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保存规则";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "规则ID：";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.txtNewContent);
            this.groupBox4.Location = new System.Drawing.Point(13, 308);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(1205, 212);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "替换内容：";
            // 
            // txtNewContent
            // 
            this.txtNewContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNewContent.Location = new System.Drawing.Point(4, 22);
            this.txtNewContent.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewContent.Multiline = true;
            this.txtNewContent.Name = "txtNewContent";
            this.txtNewContent.Size = new System.Drawing.Size(1197, 186);
            this.txtNewContent.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.ckIsFileContent);
            this.groupBox3.Controls.Add(this.ckIsFileName);
            this.groupBox3.Controls.Add(this.ckIsWholeMatch);
            this.groupBox3.Controls.Add(this.ckIsIgnoreCase);
            this.groupBox3.Controls.Add(this.ckIsRegex);
            this.groupBox3.Controls.Add(this.txtOldContent);
            this.groupBox3.Location = new System.Drawing.Point(13, 44);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1205, 256);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "查找内容：";
            // 
            // ckIsFileContent
            // 
            this.ckIsFileContent.AutoSize = true;
            this.ckIsFileContent.Location = new System.Drawing.Point(131, 211);
            this.ckIsFileContent.Margin = new System.Windows.Forms.Padding(4);
            this.ckIsFileContent.Name = "ckIsFileContent";
            this.ckIsFileContent.Size = new System.Drawing.Size(89, 19);
            this.ckIsFileContent.TabIndex = 16;
            this.ckIsFileContent.Text = "文件内容";
            this.ckIsFileContent.UseVisualStyleBackColor = true;
            this.ckIsFileContent.CheckedChanged += new System.EventHandler(this.ckIsFileContent_CheckedChanged);
            // 
            // ckIsFileName
            // 
            this.ckIsFileName.AutoSize = true;
            this.ckIsFileName.Location = new System.Drawing.Point(9, 211);
            this.ckIsFileName.Margin = new System.Windows.Forms.Padding(4);
            this.ckIsFileName.Name = "ckIsFileName";
            this.ckIsFileName.Size = new System.Drawing.Size(74, 19);
            this.ckIsFileName.TabIndex = 15;
            this.ckIsFileName.Text = "文件名";
            this.ckIsFileName.UseVisualStyleBackColor = true;
            this.ckIsFileName.CheckedChanged += new System.EventHandler(this.ckIsFileName_CheckedChanged);
            // 
            // ckIsWholeMatch
            // 
            this.ckIsWholeMatch.AutoSize = true;
            this.ckIsWholeMatch.Location = new System.Drawing.Point(252, 184);
            this.ckIsWholeMatch.Margin = new System.Windows.Forms.Padding(4);
            this.ckIsWholeMatch.Name = "ckIsWholeMatch";
            this.ckIsWholeMatch.Size = new System.Drawing.Size(89, 19);
            this.ckIsWholeMatch.TabIndex = 14;
            this.ckIsWholeMatch.Text = "整字匹配";
            this.ckIsWholeMatch.UseVisualStyleBackColor = true;
            this.ckIsWholeMatch.CheckedChanged += new System.EventHandler(this.ckIsWholeMatch_CheckedChanged);
            // 
            // ckIsIgnoreCase
            // 
            this.ckIsIgnoreCase.AutoSize = true;
            this.ckIsIgnoreCase.Location = new System.Drawing.Point(131, 184);
            this.ckIsIgnoreCase.Margin = new System.Windows.Forms.Padding(4);
            this.ckIsIgnoreCase.Name = "ckIsIgnoreCase";
            this.ckIsIgnoreCase.Size = new System.Drawing.Size(104, 19);
            this.ckIsIgnoreCase.TabIndex = 13;
            this.ckIsIgnoreCase.Text = "忽略大小写";
            this.ckIsIgnoreCase.UseVisualStyleBackColor = true;
            // 
            // ckIsRegex
            // 
            this.ckIsRegex.AutoSize = true;
            this.ckIsRegex.Location = new System.Drawing.Point(9, 184);
            this.ckIsRegex.Margin = new System.Windows.Forms.Padding(4);
            this.ckIsRegex.Name = "ckIsRegex";
            this.ckIsRegex.Size = new System.Drawing.Size(104, 19);
            this.ckIsRegex.TabIndex = 12;
            this.ckIsRegex.Text = "正则表达式";
            this.ckIsRegex.UseVisualStyleBackColor = true;
            this.ckIsRegex.CheckedChanged += new System.EventHandler(this.ckIsRegex_CheckedChanged);
            // 
            // txtOldContent
            // 
            this.txtOldContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOldContent.Location = new System.Drawing.Point(9, 25);
            this.txtOldContent.Margin = new System.Windows.Forms.Padding(4);
            this.txtOldContent.Multiline = true;
            this.txtOldContent.Name = "txtOldContent";
            this.txtOldContent.Size = new System.Drawing.Size(1187, 150);
            this.txtOldContent.TabIndex = 0;
            // 
            // txtRuleID
            // 
            this.txtRuleID.Enabled = false;
            this.txtRuleID.Location = new System.Drawing.Point(428, 10);
            this.txtRuleID.Margin = new System.Windows.Forms.Padding(4);
            this.txtRuleID.Name = "txtRuleID";
            this.txtRuleID.Size = new System.Drawing.Size(132, 25);
            this.txtRuleID.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "规则名：";
            // 
            // txtRuleName
            // 
            this.txtRuleName.Location = new System.Drawing.Point(87, 10);
            this.txtRuleName.Margin = new System.Windows.Forms.Padding(4);
            this.txtRuleName.Name = "txtRuleName";
            this.txtRuleName.Size = new System.Drawing.Size(220, 25);
            this.txtRuleName.TabIndex = 4;
            // 
            // tabPageSelectRule
            // 
            this.tabPageSelectRule.Controls.Add(this.btnInput);
            this.tabPageSelectRule.Controls.Add(this.btnRuleOutput);
            this.tabPageSelectRule.Controls.Add(this.dataGridRuleConfig);
            this.tabPageSelectRule.Controls.Add(this.btnDel);
            this.tabPageSelectRule.Controls.Add(this.btnUpdate);
            this.tabPageSelectRule.Controls.Add(this.btnSelectAll);
            this.tabPageSelectRule.Controls.Add(this.btnAdd);
            this.tabPageSelectRule.Controls.Add(this.btnSelectNone);
            this.tabPageSelectRule.Controls.Add(this.btnSelectOK);
            this.tabPageSelectRule.Controls.Add(this.btnSelectInverse);
            this.tabPageSelectRule.Location = new System.Drawing.Point(4, 25);
            this.tabPageSelectRule.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageSelectRule.Name = "tabPageSelectRule";
            this.tabPageSelectRule.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageSelectRule.Size = new System.Drawing.Size(1232, 600);
            this.tabPageSelectRule.TabIndex = 0;
            this.tabPageSelectRule.Text = "选择规则";
            this.tabPageSelectRule.UseVisualStyleBackColor = true;
            // 
            // btnInput
            // 
            this.btnInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnInput.Location = new System.Drawing.Point(443, 562);
            this.btnInput.Margin = new System.Windows.Forms.Padding(4);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(100, 29);
            this.btnInput.TabIndex = 11;
            this.btnInput.Text = "导入规则";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnRuleOutput
            // 
            this.btnRuleOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRuleOutput.Location = new System.Drawing.Point(335, 562);
            this.btnRuleOutput.Margin = new System.Windows.Forms.Padding(4);
            this.btnRuleOutput.Name = "btnRuleOutput";
            this.btnRuleOutput.Size = new System.Drawing.Size(100, 29);
            this.btnRuleOutput.TabIndex = 10;
            this.btnRuleOutput.Text = "导出规则";
            this.btnRuleOutput.UseVisualStyleBackColor = true;
            this.btnRuleOutput.Click += new System.EventHandler(this.btnRuleOutput_Click);
            // 
            // RuleConfigSelectBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 654);
            this.Controls.Add(this.tabRuleConfig);
            this.Controls.Add(this.statusStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1255, 691);
            this.Name = "RuleConfigSelectBox";
            this.Text = "RuleConfigSelectBox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RuleConfigSelectBox_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRuleConfig)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabRuleConfig.ResumeLayout(false);
            this.tabPageAdd.ResumeLayout(false);
            this.tabPageAdd.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPageSelectRule.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridRuleConfig;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnSelectNone;
        private System.Windows.Forms.Button btnSelectInverse;
        private System.Windows.Forms.Button btnSelectOK;
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
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.TabControl tabRuleConfig;
        private System.Windows.Forms.TabPage tabPageSelectRule;
        private System.Windows.Forms.TabPage tabPageAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRuleID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRuleName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtNewContent;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox ckIsFileContent;
        private System.Windows.Forms.CheckBox ckIsFileName;
        private System.Windows.Forms.CheckBox ckIsWholeMatch;
        private System.Windows.Forms.CheckBox ckIsIgnoreCase;
        private System.Windows.Forms.CheckBox ckIsRegex;
        private System.Windows.Forms.TextBox txtOldContent;
        private System.Windows.Forms.Button btnRuleOutput;
        private System.Windows.Forms.Button btnInput;
    }
}