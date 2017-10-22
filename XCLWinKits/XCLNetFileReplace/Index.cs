using Aspose.Words.Replacing;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace XCLNetFileReplace
{
    public partial class Index : BaseForm.BaseFormClass
    {
        private Computer pc = new Computer();
        private string openFileFolderPath = string.Empty;//打开的文件所在的公共目录,如"C:\XCL\"
        private object lockObject = new object();

        private delegate void Delegate_UpdateStatus(Model.DoState doState);

        private delegate DataLayer.Model.FileReplace_File Delegate_DoIt(DataLayer.Model.FileReplace_File model);

        private delegate void Delegate_VoidMethod();

        private DataLayer.BLL.v_FileReplace_File v_fileBLL = new DataLayer.BLL.v_FileReplace_File();
        private DataLayer.BLL.FileReplace_File fileBLL = new DataLayer.BLL.FileReplace_File();
        private DataLayer.BLL.UserSetting userSettingBLL = new DataLayer.BLL.UserSetting();
        private DataLayer.BLL.FileReplace_RuleConfig ruleConfigBLL = new DataLayer.BLL.FileReplace_RuleConfig();
        private DataLayer.BLL.v_FileReplace_RuleConfig v_ruleConfigBLL = new DataLayer.BLL.v_FileReplace_RuleConfig();

        private DataLayer.Model.FileReplaceSetting replaceSetting = new DataLayer.Model.FileReplaceSetting();
        private string[] defaultExt = { "xls", "xlsx", "csv", "xlt", "doc", "docx"/*, "ppt", "pptx","pdf"*/ };//这些格式由aspose去处理
        private string[] excelExt = { "xls", "xlsx", "csv", "xlt" };
        private string[] docExt = { "doc", "docx" };
        //private string[] pptExt = { "ppt", "pptx" };
        //private string[] pdfExt = { "pdf"};

        /// <summary>
        /// 构造方法
        /// </summary>
        public Index()
        {
            InitializeComponent();
            this.InitData();
        }

        /// <summary>
        /// 初始化基本数据
        /// </summary>
        private void InitData()
        {
            this.replaceSetting = userSettingBLL.GetFileReplaceSetting() ?? new DataLayer.Model.FileReplaceSetting();
            this.dgFiles.AutoGenerateColumns = false;
            this.dataGridRuleConfig.AutoGenerateColumns = false;
            fileBLL.Clear();
            this.InitCurrentRuleList();
            //初始化用户默认配置
            this.txtOutPutPath.Text = this.replaceSetting.OutPutPath;
            this.txtFileFirstName.Text = this.replaceSetting.PrefixName;
            this.txtFileLastName.Text = this.replaceSetting.SuffixName;
            if (this.replaceSetting.IsKeepDataFormat.HasValue)
            {
                this.ckExcelOptionIsKeepDataFormat.Checked = this.replaceSetting.IsKeepDataFormat.Value;
            }
            if (this.replaceSetting.IsKeepFormula.HasValue)
            {
                this.ckExcelOptionIsKeepFormula.Checked = this.replaceSetting.IsKeepFormula.Value;
            }
            this.toolStripStatusLabel2.Text = new Model.DoState().ToString();
        }

        /// <summary>
        /// 初始化已选配置
        /// </summary>
        public void InitCurrentRuleList()
        {
            List<DataLayer.Model.v_FileReplace_RuleConfig> ruleLst = null;
            var settings = this.userSettingBLL.GetFileReplaceSetting();
            if (null != settings && null != settings.RuleConfigIds && settings.RuleConfigIds.Count > 0)
            {
                ruleLst = this.v_ruleConfigBLL.GetAllList().Where(k => settings.RuleConfigIds.Contains(k.RuleConfigID)).ToList();
            }
            this.dataGridRuleConfig.DataSource = XCLNetTools.DataSource.DataTableHelper.ToDataTable(ruleLst);
        }

        #region 导航菜单

        private void 打开文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Multiselect = true;
            if (!string.IsNullOrWhiteSpace(this.replaceSetting.LastOpenFolderPath) && System.IO.Directory.Exists(this.replaceSetting.LastOpenFolderPath))
            {
                openFile.InitialDirectory = this.replaceSetting.LastOpenFolderPath;
            }
            if (openFile.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }
            try
            {
                this.InitFiles(openFile.FileNames);
                if (null != openFile.FileNames && openFile.FileNames.Length > 0)
                {
                    string fName = XCLNetTools.FileHandler.ComFile.GetFileName(openFile.FileNames[0]);
                    this.openFileFolderPath = openFile.FileNames[0].Replace(fName, "");
                    this.replaceSetting.LastOpenFolderPath = this.openFileFolderPath;
                }
            }
            catch
            {
                MessageBox.Show("系统错误，请重新打开有效文件！", "系统提示");
            }
        }

        private void 打开文件夹ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openFolder = new FolderBrowserDialog();
            if (!string.IsNullOrWhiteSpace(this.replaceSetting.LastOpenFolderPath) && System.IO.Directory.Exists(this.replaceSetting.LastOpenFolderPath))
            {
                openFolder.SelectedPath = this.replaceSetting.LastOpenFolderPath;
            }
            if (openFolder.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }
            try
            {
                string[] files = XCLNetTools.FileHandler.ComFile.GetFolderFilesByRecursion(openFolder.SelectedPath);
                this.InitFiles(files);
                this.openFileFolderPath = openFolder.SelectedPath;
                this.replaceSetting.LastOpenFolderPath = this.openFileFolderPath;
            }
            catch
            {
                MessageBox.Show("系统错误，请重新打开有效文件夹！", "系统提示");
            }
        }

        private void 导出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var lst = new DataLayer.BLL.v_FileReplace_File_ForExport().GetAllList();
            if (null == lst || lst.Count == 0)
            {
                MessageBox.Show("当前没有任何数据可供导出！", "系统提示");
                return;
            }
            FolderBrowserDialog openFolder = new FolderBrowserDialog();
            openFolder.Description = "请选择要存放的目录！";
            if (openFolder.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }
            string folderPath = openFolder.SelectedPath.TrimEnd('\\');
            Aspose.Cells.Workbook wb = new Aspose.Cells.Workbook();
            wb.Worksheets[0].Cells.ImportDataTable(XCLNetTools.DataSource.DataTableHelper.ToDataTable(lst), true, 0, 0);
            string filePath = string.Format(@"{0}\XCLNetFileRelace_{1:yyyyMMddHHmmssfff}.xlsx", folderPath, DateTime.Now);
            wb.Save(filePath, Aspose.Cells.SaveFormat.Xlsx);
            if (MessageBox.Show("导出成功，是否打开该文件？", "系统提示", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(filePath);
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion 导航菜单

        /// <summary>
        /// 执行
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            var lst = this.fileBLL.GetAllList();

            #region 合法性验证

            if (null == lst || lst.Count == 0)
            {
                MessageBox.Show("请先选择待处理的文件！", "系统提示");
                return;
            }

            if ((null == this.dataGridRuleConfig.Rows || this.dataGridRuleConfig.Rows.Count == 0) && string.IsNullOrEmpty(this.txtFileFirstName.Text) && string.IsNullOrEmpty(this.txtFileLastName.Text))
            {
                MessageBox.Show("当前不需要处理任何文件，请先配置相关信息！", "系统提示");
                return;
            }

            if (!string.IsNullOrEmpty(this.txtOutPutPath.Text))
            {
                if (XCLNetTools.FileHandler.FileDirectory.DirectoryExists(this.txtOutPutPath.Text))
                {
                    //检查是否有文件
                    if (!XCLNetTools.FileHandler.FileDirectory.IsEmpty(this.txtOutPutPath.Text))
                    {
                        if (MessageBox.Show("您指定的输出目录不是空目录，是否继续？", "系统提示", MessageBoxButtons.YesNo) == DialogResult.No)
                        {
                            return;
                        }
                    }
                }
                else
                {
                    if (!XCLNetTools.FileHandler.FileDirectory.MakeDirectory(this.txtOutPutPath.Text))
                    {
                        MessageBox.Show("输出目录不存在，请选择有效的输出目录！", "系统提示");
                        return;
                    }
                }
            }

            if (!lst.Exists(k => !k.IsDone))
            {
                MessageBox.Show("文件都已处理，请重新打开要处理的文件！", "系统提示");
                return;
            }

            #endregion 合法性验证

            #region 将选项保存至配置文件中

            var ruleIdLst = new List<int>();
            var config = this.userSettingBLL.GetFirstModel() ?? new DataLayer.Model.UserSetting();
            if (null != this.dataGridRuleConfig.Rows && this.dataGridRuleConfig.Rows.Count > 0)
            {
                for (var i = 0; i < this.dataGridRuleConfig.Rows.Count; i++)
                {
                    ruleIdLst.Add(XCLNetTools.Common.DataTypeConvert.ToInt(this.dataGridRuleConfig.Rows[i].Cells["grid_RuleConfigID"].Value));
                }
            }

            this.replaceSetting.OutPutPath = this.txtOutPutPath.Text;
            this.replaceSetting.PrefixName = this.txtFileFirstName.Text;
            this.replaceSetting.SuffixName = this.txtFileLastName.Text;
            this.replaceSetting.IsKeepDataFormat = this.ckExcelOptionIsKeepDataFormat.Checked;
            this.replaceSetting.IsKeepFormula = this.ckExcelOptionIsKeepFormula.Checked;
            this.replaceSetting.RuleConfigIds = ruleIdLst;

            config.FileReplaceSetting = XCLNetTools.Serialize.JSON.Serialize(this.replaceSetting);

            this.userSettingBLL.Add(config);

            #endregion 将选项保存至配置文件中

            #region 任务处理

            this.btnSave.Enabled = false;
            Model.DoState doState = new Model.DoState();
            doState.SumCount = lst.Count;
            foreach (var m in lst)
            {
                this.SetTextLogValue(string.Format("正在处理文件：{0}", m.FileName));
                Delegate_DoIt dg = new Delegate_DoIt(this.DoIt);
                IAsyncResult result = dg.BeginInvoke(m, new AsyncCallback(this.GetResultCallBack), doState);
            }

            #endregion 任务处理
        }

        /// <summary>
        /// 开始处理文件
        /// </summary>
        private DataLayer.Model.FileReplace_File DoIt(DataLayer.Model.FileReplace_File model)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            int replaceCount = 0;
            Regex reg = null;
            List<string> strRemark = new List<string>();
            model.IsDone = true;

            Aspose.Cells.Cell currentCell = null;
            Aspose.Cells.CellValueType currentCellType = Aspose.Cells.CellValueType.IsString;
            string cellValue = string.Empty;
            bool tempBool;
            int tempInt;
            double tempDouble;
            DateTime tempDateTime;
            bool isCellReplaced = false;
            int cellMatchCount;

            bool isDefaultExt = defaultExt.Contains(model.ExtensionName);
            bool isExcelExt = excelExt.Contains(model.ExtensionName);
            bool isDocExt = docExt.Contains(model.ExtensionName);
            //bool isPPTExt = pptExt.Contains(model.ExtensionName);
            //bool isPdfExt = pdfExt.Contains(model.ExtensionName);
            bool isTxtFile = XCLNetTools.FileHandler.ComFile.IsTextFile(model.Path);
            bool isNeedCopy = !string.IsNullOrEmpty(this.txtOutPutPath.Text);
            string realPath = model.Path;//被操作的文件实际路径，如果没有指定输出目录，则为原路径，如果指定了输出目录，则为copy到输出目录中后的路径
            string filetitle = XCLNetTools.FileHandler.ComFile.GetFileName(model.Path, false);//文件名，不含扩展名
            string newFileTitle = string.Empty;

            if (!System.IO.File.Exists(model.Path))
            {
                model.Remark = "文件不存在！";
                model.ProcessState = (int)DataLayer.Common.DataEnum.FileReplace_File_ProcessStateEnum.无需处理;
                return model;
            }

            if (string.IsNullOrEmpty(model.ExtensionName))
            {
                model.Remark = "无法确认文件类型！";
                model.ProcessState = (int)DataLayer.Common.DataEnum.FileReplace_File_ProcessStateEnum.无需处理;
                return model;
            }

            try
            {
                #region 先处理替换文件名

                for (int ruleIndex = 0; ruleIndex < this.dataGridRuleConfig.Rows.Count; ruleIndex++)
                {
                    var ruleModel = XCLNetTools.Generic.ListHelper.DataRowToModel<DataLayer.Model.v_FileReplace_RuleConfig>(((DataRowView)dataGridRuleConfig.Rows[ruleIndex].DataBoundItem).Row);
                    if (null == ruleModel || !ruleModel.IsFileName)
                    {
                        continue;
                    }

                    #region 是否启用正则替换

                    if (ruleModel.IsRegex)
                    {
                        reg = ruleModel.IsIgnoreCase ? new Regex(ruleModel.OldContent, RegexOptions.IgnoreCase) : new Regex(ruleModel.OldContent);
                    }
                    else
                    {
                        string newExpStr = ruleModel.IsWholeMatch ? string.Format(@"\b{0}\b", Regex.Escape(ruleModel.OldContent)) : Regex.Escape(ruleModel.OldContent);
                        reg = ruleModel.IsIgnoreCase ? new Regex(newExpStr, RegexOptions.IgnoreCase) : new Regex(newExpStr);
                    }

                    #endregion 是否启用正则替换

                    #region 判断是否替换文件名

                    replaceCount = reg.Matches(filetitle).Count;
                    strRemark.Add(string.Format("规则【{0}】文件名替换【{1}】处；", ruleModel.Name, replaceCount));
                    filetitle = reg.Replace(filetitle, ruleModel.NewContent);
                    model.ProcessBlockCount += replaceCount;

                    #endregion 判断是否替换文件名
                }

                filetitle = string.Format("{0}{1}{2}", this.txtFileFirstName.Text, filetitle, this.txtFileLastName.Text);

                bool isFileNameChanged = !string.Equals(XCLNetTools.FileHandler.ComFile.GetFileName(model.Path, false), filetitle, StringComparison.OrdinalIgnoreCase);

                if (isNeedCopy)
                {
                    if (isFileNameChanged)
                    {
                        realPath = XCLNetTools.FileHandler.ComFile.GetFileFolderPath(model.Path) + "\\" + filetitle + "." + model.ExtensionName;
                    }
                    realPath = realPath.Replace(this.openFileFolderPath.TrimEnd('\\'), this.txtOutPutPath.Text.TrimEnd('\\'));
                    XCLNetTools.FileHandler.ComFile.CopyFile(model.Path, realPath);
                    if (!System.IO.File.Exists(realPath))
                    {
                        model.Remark = "复制到输出目录执行失败！";
                        model.ProcessState = (int)DataLayer.Common.DataEnum.FileReplace_File_ProcessStateEnum.处理失败;
                        return model;
                    }
                }
                else
                {
                    if (isFileNameChanged)
                    {
                        newFileTitle = filetitle + "." + model.ExtensionName;
                        this.pc.FileSystem.RenameFile(model.Path, newFileTitle);
                        realPath = XCLNetTools.FileHandler.ComFile.ChangePathByFileName(realPath, newFileTitle);
                    }
                }

                #endregion 先处理替换文件名

                #region 替换文件内容

                Aspose.Cells.Workbook wb = null;
                Aspose.Words.Document wordDocument = null;
                string textContent = null;

                for (int ruleIndex = 0; ruleIndex < this.dataGridRuleConfig.Rows.Count; ruleIndex++)
                {
                    var ruleModel = XCLNetTools.Generic.ListHelper.DataRowToModel<DataLayer.Model.v_FileReplace_RuleConfig>(((DataRowView)dataGridRuleConfig.Rows[ruleIndex].DataBoundItem).Row);
                    if (null == ruleModel || !ruleModel.IsFileContent)
                    {
                        continue;
                    }

                    #region 验证扩展名及是否为文本文件

                    if (!isDefaultExt && !isTxtFile && ruleModel.IsFileContent)
                    {
                        //非aspose能处理的文件，且非文本文件，则不能替换内容！
                        strRemark.Add(string.Format("规则【{0}】不支持替换该文件的内容！", ruleModel.Name));
                        continue;
                    }

                    #endregion 验证扩展名及是否为文本文件

                    #region 是否启用正则替换

                    if (ruleModel.IsRegex)
                    {
                        reg = ruleModel.IsIgnoreCase ? new Regex(ruleModel.OldContent, RegexOptions.IgnoreCase) : new Regex(ruleModel.OldContent);
                    }
                    else
                    {
                        string newExpStr = ruleModel.IsWholeMatch ? string.Format(@"\b{0}\b", Regex.Escape(ruleModel.OldContent)) : Regex.Escape(ruleModel.OldContent);
                        reg = ruleModel.IsIgnoreCase ? new Regex(newExpStr, RegexOptions.IgnoreCase) : new Regex(newExpStr);
                    }

                    #endregion 是否启用正则替换

                    #region 开始替换文件内容

                    if (isDefaultExt)
                    {
                        if (isExcelExt)
                        {
                            #region 处理excel文件

                            if (null == wb)
                            {
                                wb = new Aspose.Cells.Workbook(realPath);
                            }

                            for (int i = 0; i < wb.Worksheets.Count; i++)
                            {
                                Aspose.Cells.Cells sheetCells = wb.Worksheets[i].Cells;

                                for (int cellsRowIndex = 0; cellsRowIndex < sheetCells.MaxDataRow + 1; cellsRowIndex++)
                                {
                                    for (int cellsColumn = 0; cellsColumn < sheetCells.MaxDataColumn + 1; cellsColumn++)
                                    {
                                        currentCell = sheetCells[cellsRowIndex, cellsColumn];

                                        if (currentCell.IsFormula && this.ckExcelOptionIsKeepFormula.Checked)
                                        {
                                            continue;
                                        }

                                        cellValue = Convert.ToString(currentCell.Value);
                                        if (string.IsNullOrEmpty(cellValue))
                                        {
                                            continue;
                                        }

                                        cellMatchCount = reg.Matches(cellValue).Count;

                                        if (cellMatchCount == 0)
                                        {
                                            continue;
                                        }

                                        cellValue = reg.Replace(cellValue, ruleModel.NewContent);

                                        currentCellType = this.ckExcelOptionIsKeepDataFormat.Checked ? currentCell.Type : Aspose.Cells.CellValueType.IsString;

                                        switch (currentCellType)
                                        {
                                            case Aspose.Cells.CellValueType.IsBool:
                                                if (bool.TryParse(cellValue, out tempBool))
                                                {
                                                    currentCell.PutValue(tempBool);
                                                    isCellReplaced = true;
                                                }
                                                break;

                                            case Aspose.Cells.CellValueType.IsDateTime:
                                                if (DateTime.TryParse(cellValue, out tempDateTime))
                                                {
                                                    currentCell.PutValue(tempDateTime);
                                                    isCellReplaced = true;
                                                }
                                                break;

                                            case Aspose.Cells.CellValueType.IsNumeric:
                                                if (int.TryParse(cellValue, out tempInt))
                                                {
                                                    currentCell.PutValue(tempInt);
                                                    isCellReplaced = true;
                                                }
                                                else
                                                {
                                                    if (double.TryParse(cellValue, out tempDouble))
                                                    {
                                                        currentCell.PutValue(tempDouble);
                                                        isCellReplaced = true;
                                                    }
                                                }
                                                break;

                                            default:
                                                currentCell.PutValue(cellValue);
                                                isCellReplaced = true;
                                                break;
                                        }

                                        if (isCellReplaced)
                                        {
                                            replaceCount += cellMatchCount;
                                        }
                                    }
                                }
                            }

                            #endregion 处理excel文件
                        }
                        else if (isDocExt)
                        {
                            #region 处理word

                            if (null == wordDocument)
                            {
                                wordDocument = new Aspose.Words.Document(realPath);
                            }
                            var finder = new FindReplaceOptions();
                            replaceCount = wordDocument.Range.Replace(reg, ruleModel.NewContent, finder);

                            #endregion 处理word
                        }
                        //else if (isPPTExt)
                        //{
                        //    #region 处理PPT
                        //    Aspose.Slides.Pptx.PresentationEx pptPres = new Aspose.Slides.Pptx.PresentationEx(realPath);
                        //    #endregion
                        //}
                        //else if (isPdfExt)
                        //{
                        //    #region 处理pdf文件
                        //    Aspose.Pdf.Kit.PdfContentEditor pdfEditor = new Aspose.Pdf.Kit.PdfContentEditor();
                        //    pdfEditor.BindPdf(realPath);
                        //    pdfEditor.ReplaceText(this.txtOldValue.Text, this.txtNew.Text);
                        //    pdfEditor.Save(realPath);
                        //    #endregion
                        //}
                    }
                    else
                    {
                        #region 处理文本文件

                        if (null == textContent)
                        {
                            textContent = System.IO.File.ReadAllText(realPath, System.Text.Encoding.Default) ?? "";
                        }
                        replaceCount = reg.Matches(textContent).Count;
                        textContent = reg.Replace(textContent, ruleModel.NewContent);

                        #endregion 处理文本文件
                    }
                    strRemark.Add(string.Format("规则【{0}】文件内容替换【{1}】处；", ruleModel.Name, replaceCount));

                    #endregion 开始替换文件内容

                    this.SetTextLogValue(string.Format("正在处理文件【{0}】，应用规则【{1}】", model.FileName, ruleModel.Name));

                    model.ProcessBlockCount += replaceCount;
                }

                if (null != wb)
                {
                    if (this.ckExcelOptionIsKeepFormula.Checked)
                    {
                        wb.CalculateFormula();
                    }
                    wb.Save(realPath);
                }
                if (null != wordDocument)
                {
                    wordDocument.Save(realPath);
                }
                if (null != textContent)
                {
                    System.IO.File.WriteAllText(realPath, textContent, System.Text.Encoding.Default);
                }

                #endregion 替换文件内容

                if (strRemark.Count > 0)
                {
                    model.Remark = string.Join("；", strRemark.ToArray());
                }

                model.ProcessState = (int)DataLayer.Common.DataEnum.FileReplace_File_ProcessStateEnum.处理成功;
            }
            catch (Exception e)
            {
                model.ProcessState = (int)DataLayer.Common.DataEnum.FileReplace_File_ProcessStateEnum.处理失败;
                model.Remark = e.Message;
            }
            finally
            {
                sw.Stop();
                model.ProcessDuration = (int)sw.Elapsed.TotalSeconds;
            }

            if (string.IsNullOrWhiteSpace(model.Remark))
            {
                this.SetTextLogValue(string.Format("文件【{0}】处理完毕", model.FileName));
            }
            else
            {
                this.SetTextLogValue(string.Format("文件【{0}】处理完毕（{1}）", model.FileName, model.Remark));
            }

            return model;
        }

        /// <summary>
        /// 处理文件回调函数
        /// </summary>
        private void GetResultCallBack(IAsyncResult asyncResult)
        {
            lock (this.lockObject)
            {
                Model.DoState doState = asyncResult.AsyncState as Model.DoState;
                AsyncResult result = (AsyncResult)asyncResult;
                Delegate_DoIt delegateDoit = (Delegate_DoIt)result.AsyncDelegate;
                var model = delegateDoit.EndInvoke(asyncResult);

                switch (model.ProcessState)
                {
                    case (int)DataLayer.Common.DataEnum.FileReplace_File_ProcessStateEnum.处理失败:
                        doState.FailCount += 1;
                        break;

                    case (int)DataLayer.Common.DataEnum.FileReplace_File_ProcessStateEnum.处理成功:
                        doState.SuccessCount += 1;
                        break;

                    case (int)DataLayer.Common.DataEnum.FileReplace_File_ProcessStateEnum.无需处理:
                        doState.IgnoreCount += 1;
                        break;
                }
                //更新model
                this.fileBLL.Update(model);

                if (this.InvokeRequired)
                {
                    this.Invoke(new Delegate_UpdateStatus(this.UpdateStatus), new object[] { doState });
                }
                else
                {
                    this.UpdateStatus(doState);
                }
            }
        }

        /// <summary>
        /// 更新状态栏
        /// </summary>
        private void UpdateStatus(Model.DoState doState)
        {
            this.toolStripStatusLabel2.Text = doState.ToString();
            this.toolStripProgressBar1.Value = (int)doState.DoPercent;
            if (doState.CurrentCount == doState.SumCount)
            {
                this.btnSave.Enabled = true;
                this.txtLog.AppendText("文件已全部处理完毕！" + Environment.NewLine);
                this.dgFiles.DataSource = XCLNetTools.DataSource.DataTableHelper.ToDataTable(this.v_fileBLL.GetAllList());
            }
        }

        /// <summary>
        /// 初始化状态栏
        /// </summary>
        private void InitStatus()
        {
            Model.DoState doState = new Model.DoState();
            this.toolStripStatusLabel2.Text = doState.ToString();
            this.toolStripProgressBar1.Value = (int)doState.DoPercent;
        }

        /// <summary>
        /// 设置输出目录
        /// </summary>
        private void btnOutPutPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openFolder = new FolderBrowserDialog();
            if (openFolder.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txtOutPutPath.Text = openFolder.SelectedPath;
            }
        }

        /// <summary>
        /// 初始化待处理文件
        /// </summary>
        private void InitFiles(string[] files)
        {
            if (null == files || files.Length == 0)
            {
                return;
            }

            List<DataLayer.Model.FileReplace_File> lst = new List<DataLayer.Model.FileReplace_File>();
            for (int i = 0; i < files.Length; i++)
            {
                var model = new DataLayer.Model.FileReplace_File();
                model.CreateTime = model.UpdateTime = DateTime.Now;
                model.ExtensionName = (XCLNetTools.FileHandler.ComFile.GetExtName(files[i]) ?? "").ToLower();
                if (string.IsNullOrEmpty(model.ExtensionName))
                {
                    continue;
                }
                model.FileName = XCLNetTools.FileHandler.ComFile.GetFileName(files[i]);
                model.IsDone = false;
                model.Path = files[i];
                if (!string.IsNullOrEmpty(model.Path))
                {
                    model.Path = string.Format("{0}.{1}", model.Path.Substring(0, model.Path.LastIndexOf('.')), XCLNetTools.FileHandler.ComFile.GetExtName(model.Path).ToLower());
                }
                model.ProcessBlockCount = 0;
                model.ProcessDuration = 0;
                model.ProcessState = (int)DataLayer.Common.DataEnum.FileReplace_File_ProcessStateEnum.等待处理;
                model.Remark = "";
                lst.Add(model);
            }
            fileBLL.Add(lst);

            this.dgFiles.DataSource = XCLNetTools.DataSource.DataTableHelper.ToDataTable(this.v_fileBLL.GetAllList());
            this.InitStatus();
        }

        /// <summary>
        /// 给datagridview添加行号
        /// </summary>
        private void dgFiles_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var dgv = sender as DataGridView;
            if (dgv != null)
            {
                Rectangle rect = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, dgv.RowHeadersWidth - 4, e.RowBounds.Height);
                TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dgv.RowHeadersDefaultCellStyle.Font, rect, dgv.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
            }
        }

        /// <summary>
        /// 打开输出目录
        /// </summary>
        private void btnOpenOutPath_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtOutPutPath.Text))
            {
                if (XCLNetTools.FileHandler.FileDirectory.DirectoryExists(this.txtOutPutPath.Text))
                {
                    System.Diagnostics.Process.Start("Explorer.exe", this.txtOutPutPath.Text);
                }
                else
                {
                    if (MessageBox.Show("该目录不存在，是否要创建？", "系统提示", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        if (XCLNetTools.FileHandler.FileDirectory.MakeDirectory(this.txtOutPutPath.Text))
                        {
                            MessageBox.Show("目录创建成功！", "系统提示");
                        }
                        else
                        {
                            MessageBox.Show("目录创建失败，请手动选择有效目录！", "系统提示");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("请先选择输出目录！", "系统提示");
            }
        }

        /// <summary>
        /// 无需输出目录
        /// </summary>
        private void btnNotNeedOutPutPath_Click(object sender, EventArgs e)
        {
            this.txtOutPutPath.Text = "";
        }

        /// <summary>
        /// 重写标题
        /// </summary>
        public override string SubAssemblyName
        {
            get { return Assembly.GetExecutingAssembly().GetName().Name; }
        }

        /// <summary>
        /// 选择规则
        /// </summary>
        private void btnSelectRule_Click(object sender, EventArgs e)
        {
            XCLNetFileReplace.RuleConfigSelectBox fm = new RuleConfigSelectBox(this);
            fm.ShowDialog();
        }

        /// <summary>
        /// 生成规则配置 的行号
        /// </summary>
        private void dataGridRuleConfig_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var dgv = sender as DataGridView;
            if (null == dgv) return;
            Rectangle rect = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, dgv.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dgv.RowHeadersDefaultCellStyle.Font, rect, dgv.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
            foreach (DataGridViewRow r in dgv.Rows)
            {
                foreach (DataGridViewColumn c in dgv.Columns)
                {
                    if (c.Name == "grid_IsRegex_Text" || c.Name == "grid_IsIgnoreCase_Text" || c.Name == "grid_IsWholeMatch_Text" || c.Name == "grid_IsFileName_Text" || c.Name == "grid_IsFileContent_Text")
                    {
                        if (string.Equals(r.Cells[c.Name].Value, "否"))
                        {
                            r.Cells[c.Name].Style.ForeColor = Color.Red;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 【执行】按钮切换可用/不可用状态事件
        /// </summary>
        private void btnSave_EnabledChanged(object sender, EventArgs e)
        {
            bool state = this.btnSave.Enabled;

            this.tabControlOptions.Enabled = state;

            this.btnSave.Enabled = state;
            this.btnSelectRule.Enabled = state;

            this.打开文件ToolStripMenuItem.Enabled = state;
            this.打开文件夹ToolStripMenuItem.Enabled = state;
            this.导出ToolStripMenuItem.Enabled = state;
        }

        /// <summary>
        /// 设置日志文本框的值
        /// </summary>
        public void SetTextLogValue(string logMsg)
        {
            logMsg += Environment.NewLine;
            if (this.txtLog.InvokeRequired)
            {
                this.txtLog.Invoke(new Action<string>((txt) =>
                {
                    this.txtLog.AppendText(txt);
                }), new object[] { logMsg });
            }
            else
            {
                this.txtLog.AppendText(logMsg);
            }
        }
    }
}