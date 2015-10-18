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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridRuleConfig = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRuleConfig)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridRuleConfig
            // 
            this.dataGridRuleConfig.AllowUserToAddRows = false;
            this.dataGridRuleConfig.AllowUserToDeleteRows = false;
            this.dataGridRuleConfig.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridRuleConfig.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridRuleConfig.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridRuleConfig.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridRuleConfig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRuleConfig.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridRuleConfig.Location = new System.Drawing.Point(0, 0);
            this.dataGridRuleConfig.Name = "dataGridRuleConfig";
            this.dataGridRuleConfig.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridRuleConfig.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridRuleConfig.RowTemplate.Height = 23;
            this.dataGridRuleConfig.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridRuleConfig.Size = new System.Drawing.Size(825, 388);
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grid_CreateTime.DefaultCellStyle = dataGridViewCellStyle6;
            this.grid_CreateTime.HeaderText = "创建时间";
            this.grid_CreateTime.Name = "grid_CreateTime";
            this.grid_CreateTime.ReadOnly = true;
            // 
            // grid_UpdateTime
            // 
            this.grid_UpdateTime.DataPropertyName = "UpdateTime";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grid_UpdateTime.DefaultCellStyle = dataGridViewCellStyle7;
            this.grid_UpdateTime.HeaderText = "更新时间";
            this.grid_UpdateTime.Name = "grid_UpdateTime";
            this.grid_UpdateTime.ReadOnly = true;
            // 
            // RuleConfigSelectBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 388);
            this.Controls.Add(this.dataGridRuleConfig);
            this.Name = "RuleConfigSelectBox";
            this.Text = "RuleConfigSelectBox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RuleConfigSelectBox_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRuleConfig)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridRuleConfig;
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