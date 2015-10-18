namespace XCLNetFileReplace
{
    partial class RuleConfig
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridRuleConfig = new System.Windows.Forms.DataGridView();
            this.grid_btnUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.grid_btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.grid_RuleConfigID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_OldContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_NewContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_IsRegex = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.grid_IsIgnoreCase = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.grid_IsWholeMatch = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.grid_IsFileName = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.grid_IsFileContent = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.grid_CreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_UpdateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRuleID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRuleName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtNewContent = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ckIsFileContent = new System.Windows.Forms.CheckBox();
            this.ckIsFileName = new System.Windows.Forms.CheckBox();
            this.ckIsWholeMatch = new System.Windows.Forms.CheckBox();
            this.ckIsIgnoreCase = new System.Windows.Forms.CheckBox();
            this.ckIsRegex = new System.Windows.Forms.CheckBox();
            this.txtOldContent = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRuleConfig)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.65311F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 337F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(942, 470);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridRuleConfig);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(936, 127);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "所有规则：";
            // 
            // dataGridRuleConfig
            // 
            this.dataGridRuleConfig.AllowUserToAddRows = false;
            this.dataGridRuleConfig.AllowUserToDeleteRows = false;
            this.dataGridRuleConfig.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridRuleConfig.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridRuleConfig.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridRuleConfig.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridRuleConfig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRuleConfig.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grid_btnUpdate,
            this.grid_btnDelete,
            this.grid_RuleConfigID,
            this.grid_Name,
            this.grid_OldContent,
            this.grid_NewContent,
            this.grid_IsRegex,
            this.grid_IsIgnoreCase,
            this.grid_IsWholeMatch,
            this.grid_IsFileName,
            this.grid_IsFileContent,
            this.grid_CreateTime,
            this.grid_UpdateTime});
            this.dataGridRuleConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridRuleConfig.Location = new System.Drawing.Point(3, 17);
            this.dataGridRuleConfig.Name = "dataGridRuleConfig";
            this.dataGridRuleConfig.ReadOnly = true;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridRuleConfig.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridRuleConfig.RowTemplate.Height = 23;
            this.dataGridRuleConfig.Size = new System.Drawing.Size(930, 107);
            this.dataGridRuleConfig.TabIndex = 0;
            this.dataGridRuleConfig.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRuleConfig_CellClick);
            this.dataGridRuleConfig.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridRuleConfig_RowPostPaint);
            // 
            // grid_btnUpdate
            // 
            this.grid_btnUpdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.NullValue = "修改";
            this.grid_btnUpdate.DefaultCellStyle = dataGridViewCellStyle12;
            this.grid_btnUpdate.Frozen = true;
            this.grid_btnUpdate.HeaderText = "修改操作";
            this.grid_btnUpdate.Name = "grid_btnUpdate";
            this.grid_btnUpdate.ReadOnly = true;
            this.grid_btnUpdate.Text = "修改";
            this.grid_btnUpdate.Width = 80;
            // 
            // grid_btnDelete
            // 
            this.grid_btnDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.NullValue = "删除";
            this.grid_btnDelete.DefaultCellStyle = dataGridViewCellStyle13;
            this.grid_btnDelete.Frozen = true;
            this.grid_btnDelete.HeaderText = "删除操作";
            this.grid_btnDelete.Name = "grid_btnDelete";
            this.grid_btnDelete.ReadOnly = true;
            this.grid_btnDelete.Text = "删除";
            this.grid_btnDelete.Width = 80;
            // 
            // grid_RuleConfigID
            // 
            this.grid_RuleConfigID.DataPropertyName = "RuleConfigID";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grid_RuleConfigID.DefaultCellStyle = dataGridViewCellStyle14;
            this.grid_RuleConfigID.HeaderText = "ID";
            this.grid_RuleConfigID.Name = "grid_RuleConfigID";
            this.grid_RuleConfigID.ReadOnly = true;
            this.grid_RuleConfigID.Visible = false;
            // 
            // grid_Name
            // 
            this.grid_Name.DataPropertyName = "Name";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grid_Name.DefaultCellStyle = dataGridViewCellStyle15;
            this.grid_Name.HeaderText = "名称";
            this.grid_Name.Name = "grid_Name";
            this.grid_Name.ReadOnly = true;
            // 
            // grid_OldContent
            // 
            this.grid_OldContent.DataPropertyName = "OldContent";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grid_OldContent.DefaultCellStyle = dataGridViewCellStyle16;
            this.grid_OldContent.HeaderText = "查找内容";
            this.grid_OldContent.Name = "grid_OldContent";
            this.grid_OldContent.ReadOnly = true;
            // 
            // grid_NewContent
            // 
            this.grid_NewContent.DataPropertyName = "NewContent";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grid_NewContent.DefaultCellStyle = dataGridViewCellStyle17;
            this.grid_NewContent.HeaderText = "替换内容";
            this.grid_NewContent.Name = "grid_NewContent";
            this.grid_NewContent.ReadOnly = true;
            // 
            // grid_IsRegex
            // 
            this.grid_IsRegex.DataPropertyName = "IsRegex";
            this.grid_IsRegex.HeaderText = "是否为正则表达式";
            this.grid_IsRegex.Name = "grid_IsRegex";
            this.grid_IsRegex.ReadOnly = true;
            this.grid_IsRegex.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_IsRegex.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // grid_IsIgnoreCase
            // 
            this.grid_IsIgnoreCase.DataPropertyName = "IsIgnoreCase";
            this.grid_IsIgnoreCase.HeaderText = "是否区分大小写";
            this.grid_IsIgnoreCase.Name = "grid_IsIgnoreCase";
            this.grid_IsIgnoreCase.ReadOnly = true;
            this.grid_IsIgnoreCase.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_IsIgnoreCase.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // grid_IsWholeMatch
            // 
            this.grid_IsWholeMatch.DataPropertyName = "IsWholeMatch";
            this.grid_IsWholeMatch.HeaderText = "是否整字匹配";
            this.grid_IsWholeMatch.Name = "grid_IsWholeMatch";
            this.grid_IsWholeMatch.ReadOnly = true;
            this.grid_IsWholeMatch.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_IsWholeMatch.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // grid_IsFileName
            // 
            this.grid_IsFileName.DataPropertyName = "IsFileName";
            this.grid_IsFileName.HeaderText = "是否匹配文件名";
            this.grid_IsFileName.Name = "grid_IsFileName";
            this.grid_IsFileName.ReadOnly = true;
            this.grid_IsFileName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_IsFileName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // grid_IsFileContent
            // 
            this.grid_IsFileContent.DataPropertyName = "IsFileContent";
            this.grid_IsFileContent.HeaderText = "是否匹配文件内容";
            this.grid_IsFileContent.Name = "grid_IsFileContent";
            this.grid_IsFileContent.ReadOnly = true;
            this.grid_IsFileContent.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_IsFileContent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // grid_CreateTime
            // 
            this.grid_CreateTime.DataPropertyName = "CreateTime";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grid_CreateTime.DefaultCellStyle = dataGridViewCellStyle18;
            this.grid_CreateTime.HeaderText = "创建时间";
            this.grid_CreateTime.Name = "grid_CreateTime";
            this.grid_CreateTime.ReadOnly = true;
            // 
            // grid_UpdateTime
            // 
            this.grid_UpdateTime.DataPropertyName = "UpdateTime";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grid_UpdateTime.DefaultCellStyle = dataGridViewCellStyle19;
            this.grid_UpdateTime.HeaderText = "更新时间";
            this.grid_UpdateTime.Name = "grid_UpdateTime";
            this.grid_UpdateTime.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtRuleID);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtRuleName);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(3, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(936, 331);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "规则：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "规则ID：";
            this.label2.Visible = false;
            // 
            // txtRuleID
            // 
            this.txtRuleID.Location = new System.Drawing.Point(318, 23);
            this.txtRuleID.Name = "txtRuleID";
            this.txtRuleID.Size = new System.Drawing.Size(100, 21);
            this.txtRuleID.TabIndex = 6;
            this.txtRuleID.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "规则名：";
            // 
            // txtRuleName
            // 
            this.txtRuleName.Location = new System.Drawing.Point(62, 23);
            this.txtRuleName.Name = "txtRuleName";
            this.txtRuleName.Size = new System.Drawing.Size(166, 21);
            this.txtRuleName.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(815, 294);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 31);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保存规则";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.txtNewContent);
            this.groupBox4.Location = new System.Drawing.Point(5, 189);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(922, 99);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "替换内容：";
            // 
            // txtNewContent
            // 
            this.txtNewContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewContent.Location = new System.Drawing.Point(3, 17);
            this.txtNewContent.Multiline = true;
            this.txtNewContent.Name = "txtNewContent";
            this.txtNewContent.Size = new System.Drawing.Size(916, 70);
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
            this.groupBox3.Location = new System.Drawing.Point(6, 50);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(922, 133);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "查找内容：";
            // 
            // ckIsFileContent
            // 
            this.ckIsFileContent.AutoSize = true;
            this.ckIsFileContent.Location = new System.Drawing.Point(98, 107);
            this.ckIsFileContent.Name = "ckIsFileContent";
            this.ckIsFileContent.Size = new System.Drawing.Size(72, 16);
            this.ckIsFileContent.TabIndex = 16;
            this.ckIsFileContent.Text = "文件内容";
            this.ckIsFileContent.UseVisualStyleBackColor = true;
            // 
            // ckIsFileName
            // 
            this.ckIsFileName.AutoSize = true;
            this.ckIsFileName.Location = new System.Drawing.Point(7, 107);
            this.ckIsFileName.Name = "ckIsFileName";
            this.ckIsFileName.Size = new System.Drawing.Size(60, 16);
            this.ckIsFileName.TabIndex = 15;
            this.ckIsFileName.Text = "文件名";
            this.ckIsFileName.UseVisualStyleBackColor = true;
            // 
            // ckIsWholeMatch
            // 
            this.ckIsWholeMatch.AutoSize = true;
            this.ckIsWholeMatch.Location = new System.Drawing.Point(189, 85);
            this.ckIsWholeMatch.Name = "ckIsWholeMatch";
            this.ckIsWholeMatch.Size = new System.Drawing.Size(72, 16);
            this.ckIsWholeMatch.TabIndex = 14;
            this.ckIsWholeMatch.Text = "整字匹配";
            this.ckIsWholeMatch.UseVisualStyleBackColor = true;
            this.ckIsWholeMatch.CheckedChanged += new System.EventHandler(this.ckIsWholeMatch_CheckedChanged);
            // 
            // ckIsIgnoreCase
            // 
            this.ckIsIgnoreCase.AutoSize = true;
            this.ckIsIgnoreCase.Location = new System.Drawing.Point(98, 85);
            this.ckIsIgnoreCase.Name = "ckIsIgnoreCase";
            this.ckIsIgnoreCase.Size = new System.Drawing.Size(84, 16);
            this.ckIsIgnoreCase.TabIndex = 13;
            this.ckIsIgnoreCase.Text = "区分大小写";
            this.ckIsIgnoreCase.UseVisualStyleBackColor = true;
            // 
            // ckIsRegex
            // 
            this.ckIsRegex.AutoSize = true;
            this.ckIsRegex.Location = new System.Drawing.Point(7, 85);
            this.ckIsRegex.Name = "ckIsRegex";
            this.ckIsRegex.Size = new System.Drawing.Size(84, 16);
            this.ckIsRegex.TabIndex = 12;
            this.ckIsRegex.Text = "正则表达式";
            this.ckIsRegex.UseVisualStyleBackColor = true;
            this.ckIsRegex.CheckedChanged += new System.EventHandler(this.ckIsRegex_CheckedChanged);
            // 
            // txtOldContent
            // 
            this.txtOldContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOldContent.Location = new System.Drawing.Point(7, 20);
            this.txtOldContent.Multiline = true;
            this.txtOldContent.Name = "txtOldContent";
            this.txtOldContent.Size = new System.Drawing.Size(908, 55);
            this.txtOldContent.TabIndex = 0;
            // 
            // RuleConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 470);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(958, 509);
            this.Name = "RuleConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "规则配置";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRuleConfig)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtOldContent;
        private System.Windows.Forms.TextBox txtNewContent;
        private System.Windows.Forms.CheckBox ckIsFileContent;
        private System.Windows.Forms.CheckBox ckIsFileName;
        private System.Windows.Forms.CheckBox ckIsWholeMatch;
        private System.Windows.Forms.CheckBox ckIsIgnoreCase;
        private System.Windows.Forms.CheckBox ckIsRegex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRuleName;
        private System.Windows.Forms.DataGridView dataGridRuleConfig;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRuleID;
        private System.Windows.Forms.DataGridViewButtonColumn grid_btnUpdate;
        private System.Windows.Forms.DataGridViewButtonColumn grid_btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_RuleConfigID;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_OldContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_NewContent;
        private System.Windows.Forms.DataGridViewCheckBoxColumn grid_IsRegex;
        private System.Windows.Forms.DataGridViewCheckBoxColumn grid_IsIgnoreCase;
        private System.Windows.Forms.DataGridViewCheckBoxColumn grid_IsWholeMatch;
        private System.Windows.Forms.DataGridViewCheckBoxColumn grid_IsFileName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn grid_IsFileContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_CreateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_UpdateTime;
    }
}