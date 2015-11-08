using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace XCLNetFileReplace
{
    public partial class RuleConfig : BaseForm.BaseFormClass
    {
        private DataLayer.BLL.FileReplace_RuleConfig bll = new DataLayer.BLL.FileReplace_RuleConfig();
        private static Index _mainForm = null;

        public RuleConfig(Index mainForm = null)
        {
            _mainForm = mainForm;

            InitializeComponent();

            this.InitRuleConfigGrid();

            this.ckIsFileName.Checked = true;
        }

        /// <summary>
        /// 初始化规则grid
        /// </summary>
        private void InitRuleConfigGrid()
        {
            var ruleConfigList = bll.GetAllList();
            this.dataGridRuleConfig.DataSource = ruleConfigList;
        }

        /// <summary>
        /// 根据规则id，填充该规则数据至编辑区域
        /// </summary>
        private void InitDataByRuleId(int ruleId)
        {
            var model = bll.GetModel(ruleId);
            this.txtRuleID.Text = null != model ? model.RuleConfigID.ToString() : "";
            this.txtRuleName.Text = null != model ? model.Name : "";
            this.txtNewContent.Text = null != model ? model.NewContent : "";
            this.txtOldContent.Text = null != model ? model.OldContent : "";
            this.ckIsFileContent.Checked = null != model ? model.IsFileContent : false;
            this.ckIsFileName.Checked = null != model ? model.IsFileName : false;
            this.ckIsIgnoreCase.Checked = null != model ? model.IsIgnoreCase : false;
            this.ckIsRegex.Checked = null != model ? model.IsRegex : false;
            this.ckIsWholeMatch.Checked = null != model ? model.IsWholeMatch : false;
        }

        /// <summary>
        /// 控件验证
        /// </summary>
        private void ControlValid()
        {
            if (this.ckIsRegex.Checked)
            {
                this.ckIsWholeMatch.Checked = false;
                this.ckIsWholeMatch.Enabled = false;
            }
            else
            {
                this.ckIsWholeMatch.Enabled = true;
            }

            if (!this.ckIsFileName.Checked && !this.ckIsFileContent.Checked)
            {
                this.ckIsFileName.Checked = true;
            }
        }

        public override string SubAssemblyName
        {
            get { return Assembly.GetExecutingAssembly().GetName().Name; }
        }

        #region 事件

        /// <summary>
        /// 保存
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            int ruleId = XCLNetTools.StringHander.Common.GetInt(this.txtRuleID.Text.Trim());
            DataLayer.Model.FileReplace_RuleConfig model = new DataLayer.Model.FileReplace_RuleConfig();
            model.CreateTime = model.UpdateTime = DateTime.Now;
            model.IsFileContent = this.ckIsFileContent.Checked;
            model.IsFileName = this.ckIsFileName.Checked;
            model.IsIgnoreCase = this.ckIsIgnoreCase.Checked;
            model.IsRegex = this.ckIsRegex.Checked;
            model.IsWholeMatch = this.ckIsWholeMatch.Checked;
            model.Name = this.txtRuleName.Text.Trim();
            model.NewContent = this.txtNewContent.Text.Trim();
            model.OldContent = this.txtOldContent.Text.Trim();

            if (string.IsNullOrEmpty(model.Name))
            {
                MessageBox.Show("请输入规则名！");
                return;
            }

            if (string.IsNullOrEmpty(model.OldContent))
            {
                MessageBox.Show("请输入要查找的内容！");
                return;
            }

            if (ruleId > 0 && bll.IsExist(ruleId))
            {
                model.RuleConfigID = ruleId;
                bll.Update(model);
            }
            else
            {
                bll.Add(model);
            }

            this.InitRuleConfigGrid();
        }

        /// <summary>
        /// 生成grid行号
        /// </summary>
        private void dataGridRuleConfig_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, dataGridRuleConfig.RowHeadersWidth, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dataGridRuleConfig.RowHeadersDefaultCellStyle.Font, rectangle, dataGridRuleConfig.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        /// <summary>
        /// grid中的按钮事件
        /// </summary>
        private void dataGridRuleConfig_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int ruleId = XCLNetTools.StringHander.Common.GetInt(this.dataGridRuleConfig.Rows[e.RowIndex].Cells["grid_RuleConfigID"].Value);
                switch (this.dataGridRuleConfig.Columns[e.ColumnIndex].Name)
                {
                    case "grid_btnUpdate":
                        this.InitDataByRuleId(ruleId);
                        break;

                    case "grid_btnDelete":
                        bll.Delete(ruleId);
                        this.InitRuleConfigGrid();
                        break;
                }
            }
            catch
            {
            }
        }

        /// <summary>
        /// 选择【是否为正则】
        /// </summary>
        private void ckIsRegex_CheckedChanged(object sender, EventArgs e)
        {
            this.ControlValid();
        }

        /// <summary>
        /// 选择【是否整字匹配】
        /// </summary>
        private void ckIsWholeMatch_CheckedChanged(object sender, EventArgs e)
        {
            this.ControlValid();
        }

        /// <summary>
        /// 选择【文件名】
        /// </summary>
        private void ckIsFileName_CheckedChanged(object sender, EventArgs e)
        {
            this.ControlValid();
        }

        /// <summary>
        /// 选择【文件内容】
        /// </summary>
        private void ckIsFileContent_CheckedChanged(object sender, EventArgs e)
        {
            this.ControlValid();
        }

        private void RuleConfig_FormClosing(object sender, FormClosingEventArgs e)
        {
            //刷新父窗体数据
            if (null != _mainForm)
            {
                _mainForm.InitCurrentRuleList();
            }
        }

        #endregion 事件
    }
}