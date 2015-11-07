using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace XCLNetFileReplace
{
    public partial class RuleConfigSelectBox : BaseForm.BaseFormClass
    {
        private DataLayer.BLL.FileReplace_RuleConfig bll = new DataLayer.BLL.FileReplace_RuleConfig();
        private DataLayer.BLL.UserSetting userSettingBLL = new DataLayer.BLL.UserSetting();
        private static Index _mainForm = null;

        public RuleConfigSelectBox(Index mainForm = null)
        {
            _mainForm = mainForm;

            InitializeComponent();

            this.InitRuleConfigGrid();
        }

        /// <summary>
        /// 初始化规则grid
        /// </summary>
        private void InitRuleConfigGrid()
        {
            var ruleConfigList = bll.GetAllList();
            this.dataGridRuleConfig.DataSource = ruleConfigList;
        }

        #region 事件

        /// <summary>
        /// RowPostPaint
        /// </summary>
        private void dataGridRuleConfig_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //生成行号
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, dataGridRuleConfig.RowHeadersWidth, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dataGridRuleConfig.RowHeadersDefaultCellStyle.Font, rectangle, dataGridRuleConfig.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        private void dataGridRuleConfig_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //选中默认项
            this.dataGridRuleConfig.ClearSelection();
            var fileReplaceSetting = userSettingBLL.GetFileReplaceSetting();
            if (null != fileReplaceSetting && null != fileReplaceSetting.RuleConfigIds && fileReplaceSetting.RuleConfigIds.Count > 0)
            {
                for (int i = 0; i < this.dataGridRuleConfig.Rows.Count; i++)
                {
                    var currentModel = this.dataGridRuleConfig.Rows[i].DataBoundItem as DataLayer.Model.FileReplace_RuleConfig;
                    if (null != currentModel)
                    {
                        if (fileReplaceSetting.RuleConfigIds.Contains(currentModel.RuleConfigID))
                        {
                            this.dataGridRuleConfig.Rows[i].Selected = true;
                        }
                    }
                }
            }
        }

        private void btnSelectOK_Click(object sender, System.EventArgs e)
        {
            var model = userSettingBLL.GetFirstModel();
            if (null == model)
            {
                model = new DataLayer.Model.UserSetting();
            }
            DataLayer.Model.FileReplaceSetting setting = null;
            if (!string.IsNullOrEmpty(model.FileReplaceSetting))
            {
                setting = XCLNetTools.Serialize.JSON.DeSerialize<DataLayer.Model.FileReplaceSetting>(model.FileReplaceSetting);
            }
            if (null == setting)
            {
                setting = new DataLayer.Model.FileReplaceSetting();
            }
            //获取已选行
            setting.RuleConfigIds = new List<int>();
            var selectedRows = this.dataGridRuleConfig.SelectedRows;
            if (null != selectedRows && selectedRows.Count > 0)
            {
                for (int i = 0; i < selectedRows.Count; i++)
                {
                    var currentData = selectedRows[i].DataBoundItem as DataLayer.Model.FileReplace_RuleConfig;
                    if (null != currentData)
                    {
                        setting.RuleConfigIds.Add(currentData.RuleConfigID);
                    }
                }
            }
            model.FileReplaceSetting = XCLNetTools.Serialize.JSON.Serialize(setting);
            userSettingBLL.Add(model);
            //刷新父窗体数据
            if (null != _mainForm)
            {
                _mainForm.InitCurrentRuleList();
            }
            this.Close();
        }

        private void btnSelectNone_Click(object sender, System.EventArgs e)
        {
            this.dataGridRuleConfig.ClearSelection();
        }

        private void btnSelectInverse_Click(object sender, System.EventArgs e)
        {
            for (int i = 0; i < this.dataGridRuleConfig.Rows.Count; i++)
            {
                var m = this.dataGridRuleConfig.Rows[i];
                m.Selected = !m.Selected;
            }
        }

        private void btnSelectAll_Click(object sender, System.EventArgs e)
        {
            this.dataGridRuleConfig.SelectAll();
        }

        #endregion 事件
    }
}