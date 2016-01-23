using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimeDIFF
{
    public partial class Index : BaseForm.BaseFormClass
    {
        public Index()
        {
            InitializeComponent();

            this.txtStartTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.txtStartTime.Format = DateTimePickerFormat.Custom;
            this.txtStartTime.ShowUpDown = true;

            this.txtEndTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.txtEndTime.Format = DateTimePickerFormat.Custom;
            this.txtEndTime.ShowUpDown = true;

            this.Process();
        }

        private void Process()
        {
            DateTime start = XCLNetTools.StringHander.Common.GetDateTime(this.txtStartTime.Text);
            DateTime end = XCLNetTools.StringHander.Common.GetDateTime(this.txtEndTime.Text);
            this.lbMsg.Text= XCLNetTools.StringHander.DateHelper.GetTimeString(start,end);
        }

        private void txtStartTime_ValueChanged(object sender, EventArgs e)
        {
            this.Process();
        }

        private void txtEndTime_ValueChanged(object sender, EventArgs e)
        {
            this.Process();
        }

        public override string SubAssemblyName
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Name;
            }
        }
    }
}
