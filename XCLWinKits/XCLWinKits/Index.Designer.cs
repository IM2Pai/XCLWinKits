namespace XCLWinKits
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GitHubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.作者博客ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.资料ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.正则表达式语法简明参考ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.淘宝小店ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.检查更新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.我的ABCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.捐助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMenu
            // 
            this.tabMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMenu.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabMenu.Location = new System.Drawing.Point(16, 35);
            this.tabMenu.Margin = new System.Windows.Forms.Padding(4);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(865, 442);
            this.tabMenu.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.帮助ToolStripMenuItem,
            this.我的ABCToolStripMenuItem,
            this.捐助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(897, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GitHubToolStripMenuItem,
            this.作者博客ToolStripMenuItem,
            this.资料ToolStripMenuItem,
            this.淘宝小店ToolStripMenuItem,
            this.检查更新ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // GitHubToolStripMenuItem
            // 
            this.GitHubToolStripMenuItem.Name = "GitHubToolStripMenuItem";
            this.GitHubToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.GitHubToolStripMenuItem.Text = "作者代码库";
            this.GitHubToolStripMenuItem.Click += new System.EventHandler(this.GitHubToolStripMenuItem_Click);
            // 
            // 作者博客ToolStripMenuItem
            // 
            this.作者博客ToolStripMenuItem.Name = "作者博客ToolStripMenuItem";
            this.作者博客ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.作者博客ToolStripMenuItem.Text = "作者博客";
            this.作者博客ToolStripMenuItem.Click += new System.EventHandler(this.作者博客ToolStripMenuItem_Click);
            // 
            // 资料ToolStripMenuItem
            // 
            this.资料ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.正则表达式语法简明参考ToolStripMenuItem});
            this.资料ToolStripMenuItem.Name = "资料ToolStripMenuItem";
            this.资料ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.资料ToolStripMenuItem.Text = "资料";
            // 
            // 正则表达式语法简明参考ToolStripMenuItem
            // 
            this.正则表达式语法简明参考ToolStripMenuItem.Name = "正则表达式语法简明参考ToolStripMenuItem";
            this.正则表达式语法简明参考ToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.正则表达式语法简明参考ToolStripMenuItem.Text = "正则表达式语法简明参考";
            this.正则表达式语法简明参考ToolStripMenuItem.Click += new System.EventHandler(this.正则表达式语法简明参考ToolStripMenuItem_Click);
            // 
            // 淘宝小店ToolStripMenuItem
            // 
            this.淘宝小店ToolStripMenuItem.Name = "淘宝小店ToolStripMenuItem";
            this.淘宝小店ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.淘宝小店ToolStripMenuItem.Text = "淘宝小店";
            this.淘宝小店ToolStripMenuItem.Click += new System.EventHandler(this.淘宝小店ToolStripMenuItem_Click);
            // 
            // 检查更新ToolStripMenuItem
            // 
            this.检查更新ToolStripMenuItem.Name = "检查更新ToolStripMenuItem";
            this.检查更新ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.检查更新ToolStripMenuItem.Text = "源代码";
            this.检查更新ToolStripMenuItem.Click += new System.EventHandler(this.检查更新ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 我的ABCToolStripMenuItem
            // 
            this.我的ABCToolStripMenuItem.Name = "我的ABCToolStripMenuItem";
            this.我的ABCToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.我的ABCToolStripMenuItem.Text = "我的ABC";
            this.我的ABCToolStripMenuItem.Click += new System.EventHandler(this.我的ABCToolStripMenuItem_Click);
            // 
            // 捐助ToolStripMenuItem
            // 
            this.捐助ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.捐助ToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.捐助ToolStripMenuItem.Name = "捐助ToolStripMenuItem";
            this.捐助ToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.捐助ToolStripMenuItem.Text = "软件好用？就请捐助一下吧！";
            this.捐助ToolStripMenuItem.Click += new System.EventHandler(this.捐助ToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "XCLWinKits——Windows软件工具箱";
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 492);
            this.Controls.Add(this.tabMenu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Index";
            this.Text = "XCLWinKits——Windows软件工具箱";
            this.SizeChanged += new System.EventHandler(this.Index_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 检查更新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 作者博客ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 资料ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 淘宝小店ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 正则表达式语法简明参考ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 我的ABCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GitHubToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem 捐助ToolStripMenuItem;
    }
}