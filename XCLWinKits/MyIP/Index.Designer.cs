namespace MyIP
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtInnerIP = new DevExpress.XtraEditors.TextEdit();
            this.txtPubIP = new DevExpress.XtraEditors.TextEdit();
            this.txtPubAddr = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInnerIP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPubIP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPubAddr.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(45, 25);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(134, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "我的内网IP地址是：";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(45, 76);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(134, 18);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "我的外网IP地址是：";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(59, 126);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(120, 18);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "我的外网位置是：";
            // 
            // txtInnerIP
            // 
            this.txtInnerIP.Location = new System.Drawing.Point(185, 22);
            this.txtInnerIP.Name = "txtInnerIP";
            this.txtInnerIP.Size = new System.Drawing.Size(223, 24);
            this.txtInnerIP.TabIndex = 3;
            // 
            // txtPubIP
            // 
            this.txtPubIP.Location = new System.Drawing.Point(185, 73);
            this.txtPubIP.Name = "txtPubIP";
            this.txtPubIP.Size = new System.Drawing.Size(223, 24);
            this.txtPubIP.TabIndex = 4;
            // 
            // txtPubAddr
            // 
            this.txtPubAddr.Location = new System.Drawing.Point(185, 123);
            this.txtPubAddr.Name = "txtPubAddr";
            this.txtPubAddr.Size = new System.Drawing.Size(223, 24);
            this.txtPubAddr.TabIndex = 5;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 171);
            this.Controls.Add(this.txtPubAddr);
            this.Controls.Add(this.txtPubIP);
            this.Controls.Add(this.txtInnerIP);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.Name = "Index";
            this.Text = "Index";
            ((System.ComponentModel.ISupportInitialize)(this.txtInnerIP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPubIP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPubAddr.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtInnerIP;
        private DevExpress.XtraEditors.TextEdit txtPubIP;
        private DevExpress.XtraEditors.TextEdit txtPubAddr;
    }
}