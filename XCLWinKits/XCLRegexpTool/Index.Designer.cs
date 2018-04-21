namespace XCLRegexpTool
{
    partial class Index
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtInputRegexp = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtReplaceResult = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtInputString = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ckIgnoreCase = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.ckAnyTime = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtReplaceString = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtFindResult = new System.Windows.Forms.TextBox();
            this.lbMsg = new System.Windows.Forms.Label();
            this.ckMutipLine = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtInputRegexp);
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(571, 62);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "请输入正则表达式：";
            // 
            // txtInputRegexp
            // 
            this.txtInputRegexp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInputRegexp.Location = new System.Drawing.Point(4, 22);
            this.txtInputRegexp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInputRegexp.Multiline = true;
            this.txtInputRegexp.Name = "txtInputRegexp";
            this.txtInputRegexp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInputRegexp.Size = new System.Drawing.Size(563, 36);
            this.txtInputRegexp.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Location = new System.Drawing.Point(12, 481);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1083, 144);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "替换结果：";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tableLayoutPanel1.Controls.Add(this.txtReplaceResult, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 22);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.06061F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1075, 118);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // txtReplaceResult
            // 
            this.txtReplaceResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReplaceResult.Location = new System.Drawing.Point(4, 4);
            this.txtReplaceResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtReplaceResult.Multiline = true;
            this.txtReplaceResult.Name = "txtReplaceResult";
            this.txtReplaceResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReplaceResult.Size = new System.Drawing.Size(922, 110);
            this.txtReplaceResult.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(934, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 110);
            this.panel1.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(24, 37);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 36);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "导出结果";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txtInputString);
            this.groupBox3.Location = new System.Drawing.Point(12, 178);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(1083, 159);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "待处理文本：";
            // 
            // txtInputString
            // 
            this.txtInputString.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInputString.Location = new System.Drawing.Point(4, 22);
            this.txtInputString.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInputString.Multiline = true;
            this.txtInputString.Name = "txtInputString";
            this.txtInputString.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInputString.Size = new System.Drawing.Size(1075, 133);
            this.txtInputString.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.ckMutipLine);
            this.groupBox4.Controls.Add(this.ckIgnoreCase);
            this.groupBox4.Controls.Add(this.btnOK);
            this.groupBox4.Controls.Add(this.ckAnyTime);
            this.groupBox4.Location = new System.Drawing.Point(591, 15);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(504, 62);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "选项";
            // 
            // ckIgnoreCase
            // 
            this.ckIgnoreCase.AutoSize = true;
            this.ckIgnoreCase.Location = new System.Drawing.Point(116, 28);
            this.ckIgnoreCase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckIgnoreCase.Name = "ckIgnoreCase";
            this.ckIgnoreCase.Size = new System.Drawing.Size(119, 19);
            this.ckIgnoreCase.TabIndex = 7;
            this.ckIgnoreCase.Text = "不区分大小写";
            this.ckIgnoreCase.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(395, 18);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 29);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "执行";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // ckAnyTime
            // 
            this.ckAnyTime.AutoSize = true;
            this.ckAnyTime.Location = new System.Drawing.Point(25, 28);
            this.ckAnyTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckAnyTime.Name = "ckAnyTime";
            this.ckAnyTime.Size = new System.Drawing.Size(89, 19);
            this.ckAnyTime.TabIndex = 5;
            this.ckAnyTime.Text = "实时匹配";
            this.ckAnyTime.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.txtReplaceString);
            this.groupBox5.Location = new System.Drawing.Point(12, 81);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(1083, 94);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "匹配的结果替换为：";
            // 
            // txtReplaceString
            // 
            this.txtReplaceString.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReplaceString.Location = new System.Drawing.Point(4, 22);
            this.txtReplaceString.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtReplaceString.Multiline = true;
            this.txtReplaceString.Name = "txtReplaceString";
            this.txtReplaceString.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReplaceString.Size = new System.Drawing.Size(1075, 68);
            this.txtReplaceString.TabIndex = 1;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.txtFindResult);
            this.groupBox6.Location = new System.Drawing.Point(12, 372);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Size = new System.Drawing.Size(1083, 101);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "匹配结果：";
            // 
            // txtFindResult
            // 
            this.txtFindResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFindResult.Location = new System.Drawing.Point(4, 22);
            this.txtFindResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFindResult.Multiline = true;
            this.txtFindResult.Name = "txtFindResult";
            this.txtFindResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFindResult.Size = new System.Drawing.Size(1075, 75);
            this.txtFindResult.TabIndex = 0;
            // 
            // lbMsg
            // 
            this.lbMsg.AutoSize = true;
            this.lbMsg.ForeColor = System.Drawing.Color.Red;
            this.lbMsg.Location = new System.Drawing.Point(16, 346);
            this.lbMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMsg.Name = "lbMsg";
            this.lbMsg.Size = new System.Drawing.Size(55, 15);
            this.lbMsg.TabIndex = 6;
            this.lbMsg.Text = "label1";
            // 
            // ckMutipLine
            // 
            this.ckMutipLine.AutoSize = true;
            this.ckMutipLine.Location = new System.Drawing.Point(236, 28);
            this.ckMutipLine.Margin = new System.Windows.Forms.Padding(4);
            this.ckMutipLine.Name = "ckMutipLine";
            this.ckMutipLine.Size = new System.Drawing.Size(89, 19);
            this.ckMutipLine.TabIndex = 8;
            this.ckMutipLine.Text = "多行匹配";
            this.ckMutipLine.UseVisualStyleBackColor = true;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 640);
            this.Controls.Add(this.lbMsg);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1061, 676);
            this.Name = "Index";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtInputRegexp;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtInputString;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox ckAnyTime;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtReplaceString;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtReplaceResult;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtFindResult;
        private System.Windows.Forms.Label lbMsg;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.CheckBox ckIgnoreCase;
        private System.Windows.Forms.CheckBox ckMutipLine;
    }
}