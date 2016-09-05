using System;
using System.Windows.Forms;

namespace XCLWinKits
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", AppDomain.CurrentDomain.BaseDirectory);

            bool initiallyOwned = true;
            bool isCreated;
            System.Threading.Mutex m = new System.Threading.Mutex(initiallyOwned, "XCLWinKits", out isCreated);
            if (!(initiallyOwned && isCreated))
            {
                MessageBox.Show("当前程序已经在运行了，不能打开多个哦！", "系统提示");
                Application.Exit();
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Index());
            }
        }
    }
}