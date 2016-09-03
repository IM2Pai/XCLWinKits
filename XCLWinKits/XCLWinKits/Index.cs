using System;
using System.Reflection;
using System.Windows.Forms;

namespace XCLWinKits
{
    public partial class Index : BaseForm.BaseFormClass
    {
        public Index()
        {
            InitializeComponent();
            this.InitData();
        }

        private void InitData()
        {
            #region 生成按钮

            foreach (var m in CommonHelper.ConfigHelper.Config.CategoryConfig.CategoryList)
            {
                TabPage tab = new TabPage(m.Name);
                FlowLayoutPanel flowPanel = new FlowLayoutPanel();
                flowPanel.Dock = DockStyle.Fill;
                if (null != m.CategoryItemList && m.CategoryItemList.Count > 0)
                {
                    for (int k = 0; k < m.CategoryItemList.Count; k++)
                    {
                        var model = m.CategoryItemList[k];
                        Button bt = new Button();
                        bt.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                        bt.Name = model.AssemblyName;
                        bt.Text = model.Name;
                        bt.AutoSize = true;
                        bt.Height = 25;
                        bt.Margin = new System.Windows.Forms.Padding(5);
                        bt.Padding = new System.Windows.Forms.Padding(3);
                        bt.Click += new EventHandler(bt_Click);
                        bt.MouseEnter += new EventHandler(bt_MouseEnter);
                        bt.MouseLeave += new EventHandler(bt_MouseLeave);
                        flowPanel.Controls.Add(bt);
                    }
                }
                tab.Controls.Add(flowPanel);
                this.tabMenu.TabPages.Add(tab);
            }

            #endregion 生成按钮
        }

        #region button事件

        private void bt_Click(object sender, EventArgs e)
        {
            foreach (Form fm in Application.OpenForms)
            {
                if (fm.GetType().Namespace == "XCLNetFileReplace")
                {
                    fm.Activate();
                    return;
                }
            }

            Button bt = (Button)sender;
            try
            {
                Form form = Assembly.Load(bt.Name).CreateInstance(string.Format("{0}.Index", bt.Name)) as System.Windows.Forms.Form;
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("打开失败，程序集{0}.Index还未开发完成！{1}（{2}）", bt.Name, Environment.NewLine, ex.Message), "系统提示");
            }
        }

        private void bt_MouseEnter(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            bt.ForeColor = System.Drawing.Color.Blue;
        }

        private void bt_MouseLeave(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            bt.ForeColor = System.Drawing.Color.Black;
        }

        #endregion button事件

        #region 菜单

        private void 检查更新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/xucongli1989/XCLWinKits/releases");
        }

        private void 关于本软件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new About().ShowDialog();
        }

        private void 作者博客ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://blog.csdn.net/luoyeyu1989");
        }

        private void 正则表达式语法简明参考ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(string.Format(@"{0}\Res\RegexFiles\regex0.html", Application.StartupPath.TrimEnd('\\')));
        }

        private void 淘宝小店ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://luoyeyu.taobao.com/");
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 我的ABCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.wodeabc.com");
        }

        private void GitHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/xucongli1989");
        }

        #endregion 菜单
    }
}