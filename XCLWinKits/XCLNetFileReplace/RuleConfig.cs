using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XCLNetFileReplace
{
    public partial class RuleConfig : Form
    {
        public RuleConfig()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DataLayer.BLL.FileReplace_RuleConfig bll = new DataLayer.BLL.FileReplace_RuleConfig();
            bll.Add(new DataLayer.Model.FileReplace_RuleConfig()
            {
                Name = "aaaaaaaaaaa",
                CreateTime=DateTime.Now
            });
            
        }
    }
}
