using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace XCLNetFileReplace
{
    public partial class RuleConfigSelectBox : BaseForm.BaseFormClass
    {
        private DataLayer.BLL.FileReplace_RuleConfig bll = new DataLayer.BLL.FileReplace_RuleConfig();
        private DataLayer.BLL.v_FileReplace_RuleConfig vbll = new DataLayer.BLL.v_FileReplace_RuleConfig();
        private DataLayer.BLL.UserSetting userSettingBLL = new DataLayer.BLL.UserSetting();
        private DataLayer.Model.FileReplaceSetting fileReplaceSetting = null;
        private static Index _mainForm = null;

        public RuleConfigSelectBox(Index mainForm = null)
        {
            _mainForm = mainForm;
            InitializeComponent();
            this.InitRuleConfigGrid();
            this.ckIsFileName.Checked = true;
            this.tabPageAdd.Parent = null;
            this.fileReplaceSetting = userSettingBLL.GetFileReplaceSetting();
        }

        #region 规则选择TabPage

        /// <summary>
        /// 初始化规则grid
        /// </summary>
        public void InitRuleConfigGrid()
        {
            this.dataGridRuleConfig.AutoGenerateColumns = false;
            this.dataGridRuleConfig.DataSource = this.vbll.GetAllList();
        }

        /// <summary>
        /// 生成行号
        /// </summary>
        private void dataGridRuleConfig_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, dataGridRuleConfig.RowHeadersWidth, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dataGridRuleConfig.RowHeadersDefaultCellStyle.Font, rectangle, dataGridRuleConfig.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        /// <summary>
        /// 选中默认项
        /// </summary>
        private void dataGridRuleConfig_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dataGridRuleConfig.ClearSelection();
            if (null != fileReplaceSetting && null != fileReplaceSetting.RuleConfigIds && fileReplaceSetting.RuleConfigIds.Count > 0)
            {
                for (int i = 0; i < this.dataGridRuleConfig.Rows.Count; i++)
                {
                    var currentModel = this.dataGridRuleConfig.Rows[i].DataBoundItem as DataLayer.Model.v_FileReplace_RuleConfig;
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

        /// <summary>
        /// 选好了
        /// </summary>
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
                    var currentData = selectedRows[i].DataBoundItem as DataLayer.Model.v_FileReplace_RuleConfig;
                    if (null != currentData)
                    {
                        setting.RuleConfigIds.Add(currentData.RuleConfigID);
                    }
                }
            }
            model.FileReplaceSetting = XCLNetTools.Serialize.JSON.Serialize(setting);
            userSettingBLL.Add(model);
            this.Close();
        }

        /// <summary>
        /// 全不选
        /// </summary>
        private void btnSelectNone_Click(object sender, System.EventArgs e)
        {
            this.dataGridRuleConfig.ClearSelection();
        }

        /// <summary>
        /// 反选
        /// </summary>
        private void btnSelectInverse_Click(object sender, System.EventArgs e)
        {
            for (int i = 0; i < this.dataGridRuleConfig.Rows.Count; i++)
            {
                var m = this.dataGridRuleConfig.Rows[i];
                m.Selected = !m.Selected;
            }
        }

        /// <summary>
        /// 全选
        /// </summary>
        private void btnSelectAll_Click(object sender, System.EventArgs e)
        {
            this.dataGridRuleConfig.SelectAll();
        }

        /// <summary>
        /// 添加规则
        /// </summary>
        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            this.InitDataByRuleId(0);
            this.tabPageAdd.Text = "添加规则";
            this.tabPageAdd.Parent = this.tabRuleConfig;
            this.tabRuleConfig.SelectedTab = this.tabPageAdd;
        }

        /// <summary>
        /// 修改规则
        /// </summary>
        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            var selectedRows = this.dataGridRuleConfig.SelectedRows;
            if (null == selectedRows || selectedRows.Count != 1)
            {
                MessageBox.Show("请选择一条规则进行修改！", "系统提示");
                return;
            }
            this.InitDataByRuleId(XCLNetTools.Common.DataTypeConvert.ToInt(selectedRows[0].Cells["grid_RuleConfigID"].Value));

            this.tabPageAdd.Text = "修改规则";
            this.tabPageAdd.Parent = this.tabRuleConfig;
            this.tabRuleConfig.SelectedTab = this.tabPageAdd;
        }

        /// <summary>
        /// 删除规则
        /// </summary>
        private void btnDel_Click(object sender, System.EventArgs e)
        {
            List<int> ids = new List<int>();
            var selectedRows = this.dataGridRuleConfig.SelectedRows;
            if (null == selectedRows || selectedRows.Count == 0)
            {
                MessageBox.Show("请至少选择一条规则进行删除！", "系统提示");
                return;
            }

            if (MessageBox.Show("您确定要删除这些规则？", "系统提示", MessageBoxButtons.YesNo) != System.Windows.Forms.DialogResult.Yes)
            {
                return;
            }

            for (var i = 0; i < selectedRows.Count; i++)
            {
                var id = XCLNetTools.Common.DataTypeConvert.ToInt(selectedRows[i].Cells["grid_RuleConfigID"].Value);
                bll.Delete(id);
                ids.Add(id);
            }

            this.InitRuleConfigGrid();
        }

        #endregion 规则选择TabPage

        #region 添加或修改规则TabPage

        /// <summary>
        /// 保存
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            int ruleId = XCLNetTools.Common.DataTypeConvert.ToInt(this.txtRuleID.Text.Trim());
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
                MessageBox.Show("请输入规则名！", "系统提示");
                return;
            }

            if (string.IsNullOrEmpty(model.OldContent))
            {
                MessageBox.Show("请输入要查找的内容！", "系统提示");
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
            this.tabPageAdd.Parent = null;
            this.tabRuleConfig.SelectedTab = this.tabPageSelectRule;
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

        #endregion 添加或修改规则TabPage

        private void RuleConfigSelectBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (null != _mainForm)
            {
                _mainForm.InitCurrentRuleList();
            }
        }
    }
}