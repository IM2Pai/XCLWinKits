using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace XCLNetFileReplace
{
    public partial class Index : BaseForm.BaseFormClass
    {
        private string openFileFolderPath = string.Empty;//打开的文件所在的公共目录,如"C:\XCL\"
        private object lockObject = new object();

        private delegate void Delegate_UpdateStatus(Model.DoState doState);

        private delegate DataLayer.Model.FileReplace_File Delegate_DoIt(DataLayer.Model.FileReplace_File model);

        private delegate void Delegate_VoidMethod();

        private DataLayer.BLL.FileReplace_File fileBLL = new DataLayer.BLL.FileReplace_File();
        private DataLayer.BLL.UserSetting userSettingBLL = new DataLayer.BLL.UserSetting();
        private DataLayer.BLL.FileReplace_RuleConfig ruleConfigBLL = new DataLayer.BLL.FileReplace_RuleConfig();
        private DataLayer.Model.FileReplaceSetting fileReplaceSetting = null;

        public Index()
        {
            InitializeComponent();
            this.groupBox_FileInfo.Text = "待处理文件：（支持xls、xlsx、csv、doc、docx及其它文本文件[如：txt、html等]），无需安装Office！";
            this.fileReplaceSetting = userSettingBLL.GetFileReplaceSetting();
            this.InitData();
        }

        private void InitData()
        {
            this.InitCurrentRuleList();
        }

        /// <summary>
        /// 初始化用户默认配置
        /// </summary>
        public void InitCurrentRuleList()
        {
            if (null != fileReplaceSetting)
            {
                if (null != fileReplaceSetting.RuleConfigIds && fileReplaceSetting.RuleConfigIds.Count > 0)
                {
                    this.dataGridRuleConfig.DataSource = ruleConfigBLL.GetAllList().Where(k => fileReplaceSetting.RuleConfigIds.Contains(k.RuleConfigID)).ToList();
                }
                this.txtOutPutPath.Text = fileReplaceSetting.OutPutPath;
                this.txtFileFirstName.Text = fileReplaceSetting.PrefixName;
                this.txtFileLastName.Text = fileReplaceSetting.SuffixName;
            }
        }

        #region 导航菜单

        private void 打开文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Multiselect = true;
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    this.InitFiles(openFile.FileNames);
                    if (null != openFile.FileNames && openFile.FileNames.Length > 0)
                    {
                        string fName = XCLNetTools.FileHandler.ComFile.GetFileName(openFile.FileNames[0]);
                        this.openFileFolderPath = openFile.FileNames[0].Replace(fName, "");
                    }
                }
                catch
                {
                    MessageBox.Show("系统错误，请重新打开有效文件！");
                }
            }
        }

        private void 打开文件夹ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openFolder = new FolderBrowserDialog();
            if (openFolder.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    string[] files = XCLNetTools.FileHandler.ComFile.GetFolderFilesByRecursion(openFolder.SelectedPath);
                    this.InitFiles(files);
                    this.openFileFolderPath = openFolder.SelectedPath;
                }
                catch
                {
                    MessageBox.Show("系统错误，请重新打开有效文件夹！");
                }
            }
        }

        private void 导出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var lst = fileBLL.GetAllList();
            if (null == lst || lst.Count == 0)
            {
                MessageBox.Show("当前没有任何数据可供导出！");
                return;
            }
            FolderBrowserDialog openFolder = new FolderBrowserDialog();
            openFolder.Description = "请选择要存放的目录！";
            if (openFolder.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string folderPath = openFolder.SelectedPath.TrimEnd('\\');
                Aspose.Cells.Workbook wb = new Aspose.Cells.Workbook();
                wb.Worksheets[0].Cells.ImportDataTable(XCLNetTools.Generic.ListHelper.ToDataTable((IList<DataLayer.Model.FileReplace_File>)lst), true, 0, 0);
                string filePath = string.Format(@"{0}\XCLNetFileRelace_{1:yyyyMMddHHmmssfff}.xlsx", folderPath, DateTime.Now);
                wb.Save(filePath, Aspose.Cells.SaveFormat.Xlsx);
                if (MessageBox.Show("导出成功，是否打开该文件？", "系统提示", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(filePath);
                }
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 规则配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RuleConfig fm = new RuleConfig();
            fm.ShowDialog();
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
                MessageBox.Show("请先选择待处理的文件！");
                return;
            }

            if (!XCLNetTools.FileHandler.FileDirectory.DirectoryExists(this.txtOutPutPath.Text))
            {
                if (!XCLNetTools.FileHandler.FileDirectory.MakeDirectory(this.txtOutPutPath.Text))
                {
                    MessageBox.Show("输出目录不存在，请选择有效的输出目录！");
                    return;
                }
            }
            if (!lst.Exists(k => !k.IsDone))
            {
                MessageBox.Show("文件都已处理，请重新打开要处理的文件！");
                return;
            }

            #endregion 合法性验证

            #region 将选项保存至配置文件中

            var config = this.userSettingBLL.GetFirstModel() ?? new DataLayer.Model.UserSetting();
            this.fileReplaceSetting = this.fileReplaceSetting ?? new DataLayer.Model.FileReplaceSetting();
            this.fileReplaceSetting.OutPutPath = this.txtOutPutPath.Text;
            this.fileReplaceSetting.PrefixName = this.txtFileFirstName.Text;
            this.fileReplaceSetting.SuffixName = this.txtFileLastName.Text;
            config.FileReplaceSetting = XCLNetTools.Serialize.JSON.Serialize(fileReplaceSetting);
            this.userSettingBLL.Add(config);

            #endregion 将选项保存至配置文件中

            #region 任务处理

            this.SetControlEnable(false);
            Model.DoState doState = new Model.DoState();
            doState.SumCount = lst.Count;
            foreach (var m in lst)
            {
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

            List<string> strRemark = new List<string>();
            model.IsDone = true;
            try
            {
                Regex reg = null;
                string currentExt = model.ExtensionName;
                string[] defaultExt = { "xls", "xlsx", "csv", "doc", "docx"/*, "ppt", "pptx","pdf"*/ };//这些格式由aspose去处理
                string[] excelExt = { "xls", "xlsx", "csv" };
                string[] docExt = { "doc", "docx" };
                //string[] pptExt = { "ppt", "pptx" };
                //string[] pdfExt = { "pdf"};
                bool isDefaultExt = defaultExt.Contains(currentExt);
                bool isExcelExt = excelExt.Contains(currentExt);
                bool isDocExt = docExt.Contains(currentExt);
                //bool isPPTExt = pptExt.Contains(currentExt);
                //bool isPdfExt = pdfExt.Contains(currentExt);
                bool isTxtFile = XCLNetTools.FileHandler.ComFile.IsTextFile(model.Path);

                //循环应用已选规则
                for (int ruleIndex = 0; ruleIndex < this.dataGridRuleConfig.Rows.Count; ruleIndex++)
                {
                    var ruleModel = dataGridRuleConfig.Rows[ruleIndex].DataBoundItem as DataLayer.Model.FileReplace_RuleConfig;
                    if (null == ruleModel)
                    {
                        continue;
                    }

                    #region 验证扩展名及是否为文本文件
                    
                    if (!isDefaultExt && !isTxtFile && ruleModel.IsFileContent)
                    {
                        //非aspose能处理的文件，且非文本文件，则不能替换内容，只能替换文件名！
                        strRemark.Add(string.Format("规则【{0}】不支持替换该文件的内容！",ruleModel.Name));
                        continue;
                    }

                    #endregion 验证扩展名及是否为文本文件

                    #region 是否启用正则替换

                    if (ruleModel.IsRegex)
                    {
                        reg = !ruleModel.IsIgnoreCase ? new Regex(ruleModel.OldContent) : new Regex(ruleModel.OldContent, RegexOptions.IgnoreCase);
                    }
                    else
                    {
                        string newExpStr = ruleModel.IsWholeMatch ? string.Format(@"\b{0}\b", Regex.Escape(ruleModel.OldContent)) : Regex.Escape(ruleModel.OldContent);
                        reg = !ruleModel.IsIgnoreCase ? new Regex(newExpStr) : new Regex(newExpStr, RegexOptions.IgnoreCase);
                    }

                    #endregion 是否启用正则替换

                    #region 复制到输出目录并判断是否替换文件名

                    string filePath = model.Path;
                    filePath = filePath.Replace(this.openFileFolderPath.TrimEnd('\\'), this.txtOutPutPath.Text.TrimEnd('\\'));
                    string filetitle = XCLNetTools.FileHandler.ComFile.GetFileName(filePath, false);

                    #region 是否替换文件名

                    if (ruleModel.IsFileName)
                    {
                        strRemark.Add(string.Format("规则【{0}】文件名替换【{1}】处；",ruleModel.Name, reg.Matches(filetitle).Count));
                        filetitle = reg.Replace(filetitle, ruleModel.NewContent);
                    }

                    #endregion 是否替换文件名

                    filetitle = string.Format("{0}{1}{2}", this.txtFileFirstName.Text, filetitle, this.txtFileLastName.Text);
                    filePath = XCLNetTools.FileHandler.ComFile.GetFileFolderPath(filePath) + "\\" + filetitle + "." + XCLNetTools.FileHandler.ComFile.GetExtName(filePath);

                    XCLNetTools.FileHandler.ComFile.CopyFile(model.Path, filePath);
                    if (!System.IO.File.Exists(filePath))
                    {
                        model.Remark = "输出目录中的文件未找到！";
                        model.ProcessState = DataLayer.Common.DataEnum.FileReplace_File_ProcessStateEnum.处理失败;
                        return model;
                    }

                    #endregion 复制到输出目录并判断是否替换文件名

                    #region 开始替换文件内容

                    if (ruleModel.IsFileContent)
                    {
                        int replaceCount = 0;
                        if (isDefaultExt)
                        {
                            if (isExcelExt)
                            {
                                #region 处理excel文件

                                Aspose.Cells.Workbook wb = new Aspose.Cells.Workbook(filePath);
                                for (int i = 0; i < wb.Worksheets.Count; i++)
                                {
                                    Aspose.Cells.Cells sheetCells = wb.Worksheets[i].Cells;
                                    for (int cellsRowIndex = 0; cellsRowIndex < sheetCells.MaxDataRow + 1; cellsRowIndex++)
                                    {
                                        for (int cellsColumn = 0; cellsColumn < sheetCells.MaxDataColumn + 1; cellsColumn++)
                                        {
                                            Aspose.Cells.Cell currentCell = sheetCells[cellsRowIndex, cellsColumn];
                                            string cellValue = Convert.ToString(currentCell.Value);
                                            if (!string.IsNullOrEmpty(cellValue))
                                            {
                                                replaceCount += reg.Matches(cellValue).Count;
                                                cellValue = reg.Replace(cellValue, ruleModel.NewContent);
                                                currentCell.PutValue(cellValue);
                                            }
                                        }
                                    }
                                }
                                if (replaceCount > 0)
                                {
                                    wb.Save(filePath);
                                }

                                #endregion 处理excel文件
                            }
                            else if (isDocExt)
                            {
                                #region 处理word

                                //正则无法使用特殊正则，如\s带\的。
                                Aspose.Words.Document wordDocument = new Aspose.Words.Document(filePath);
                                replaceCount = wordDocument.Range.Replace(reg, ruleModel.NewContent);
                                wordDocument.Save(filePath);

                                #endregion 处理word
                            }
                            //else if (isPPTExt)
                            //{
                            //    #region 处理PPT
                            //    Aspose.Slides.Pptx.PresentationEx pptPres = new Aspose.Slides.Pptx.PresentationEx(filePath);
                            //    #endregion
                            //}
                            //else if (isPdfExt)
                            //{
                            //    #region 处理pdf文件
                            //    Aspose.Pdf.Kit.PdfContentEditor pdfEditor = new Aspose.Pdf.Kit.PdfContentEditor();
                            //    pdfEditor.BindPdf(filePath);
                            //    pdfEditor.ReplaceText(this.txtOldValue.Text, this.txtNew.Text);
                            //    pdfEditor.Save(filePath);
                            //    #endregion
                            //}
                        }
                        else
                        {
                            #region 处理文本文件

                            string fileContent = System.IO.File.ReadAllText(filePath, System.Text.Encoding.Default);
                            replaceCount = reg.Matches(fileContent).Count;
                            fileContent = reg.Replace(fileContent, ruleModel.NewContent);
                            System.IO.File.WriteAllText(filePath, fileContent, System.Text.Encoding.Default);

                            #endregion 处理文本文件
                        }
                        strRemark.Add(string.Format("规则【{0}】文件内容替换【{1}】处；",ruleModel.Name, replaceCount));
                    }

                    #endregion 开始替换文件内容

                }

                if (strRemark.Count > 0)
                {
                    model.Remark = string.Join("；", strRemark.ToArray());
                }
                model.ProcessState = DataLayer.Common.DataEnum.FileReplace_File_ProcessStateEnum.处理成功;
            }
            catch (Exception e)
            {
                model.ProcessState = DataLayer.Common.DataEnum.FileReplace_File_ProcessStateEnum.处理失败;
                model.Remark = e.Message;
            }
            finally
            {
                sw.Stop();
                model.ProcessDuration = (int)sw.Elapsed.TotalSeconds;
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
                doState.CurrentCount += 1;
                if (model.ProcessState == DataLayer.Common.DataEnum.FileReplace_File_ProcessStateEnum.处理成功)
                {
                    doState.SuccessCount += 1;
                }
                else
                {
                    doState.FailCount += 1;
                }
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
                this.SetControlEnable(true);
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
            if (null != files && files.Length > 0)
            {
                List<DataLayer.Model.FileReplace_File> lst = new List<DataLayer.Model.FileReplace_File>();
                for (int i = 0; i < files.Length; i++)
                {
                    var model = new DataLayer.Model.FileReplace_File();
                    model.CreateTime = model.UpdateTime = DateTime.Now;
                    model.ExtensionName = (XCLNetTools.FileHandler.ComFile.GetExtName(files[i]) ?? "").ToLower();
                    model.FileName = XCLNetTools.FileHandler.ComFile.GetFileName(files[i]);
                    model.IsDone = false;
                    model.Path = files[i];
                    if (!string.IsNullOrEmpty(model.Path))
                    {
                        //将扩展名转为小写
                        model.Path = string.Format("{0}.{1}", model.Path.Substring(0, model.Path.LastIndexOf('.')), XCLNetTools.FileHandler.ComFile.GetExtName(model.Path).ToLower());
                    }
                    model.ProcessBlockCount = 0;
                    model.ProcessDuration = 0;
                    model.ProcessState = DataLayer.Common.DataEnum.FileReplace_File_ProcessStateEnum.等待处理;
                    model.Remark = "";
                    lst.Add(model);
                }
                fileBLL.Add(lst);

                this.dgFiles.DataSource = lst;
                this.InitStatus();
            }
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
        /// 设置控件是否可用
        /// </summary>
        private void SetControlEnable(bool enable)
        {
            this.btnOutPutPath.Enabled = enable;
            this.btnSave.Enabled = enable;

            this.txtFileFirstName.Enabled = enable;
            this.txtFileLastName.Enabled = enable;

            this.打开文件ToolStripMenuItem.Enabled = enable;
            this.打开文件夹ToolStripMenuItem.Enabled = enable;
            this.导出ToolStripMenuItem.Enabled = enable;
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
                    if (MessageBox.Show("该目录不存在，是否要创建？", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        if (XCLNetTools.FileHandler.FileDirectory.MakeDirectory(this.txtOutPutPath.Text))
                        {
                            MessageBox.Show("目录创建成功！");
                        }
                        else
                        {
                            MessageBox.Show("目录创建失败，请手动选择有效目录！");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("请先选择输出目录！");
            }
        }

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

        private void dataGridRuleConfig_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var dgv = sender as DataGridView;
            if (dgv != null)
            {
                Rectangle rect = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, dgv.RowHeadersWidth - 4, e.RowBounds.Height);
                TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dgv.RowHeadersDefaultCellStyle.Font, rect, dgv.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
            }
        }
    }
}