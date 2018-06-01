using System;
using System.Linq;

namespace CommonHelper
{
    public class ConfigHelper
    {
        private static CommonHelper.Model.Config _config = null;

        /// <summary>
        /// 获取当前应用程序根目录（末尾不带\）
        /// </summary>
        /// <returns></returns>
        public static string RootPath
        {
            get { return System.Windows.Forms.Application.StartupPath.TrimEnd('\\'); }
        }

        #region Config.xml

        /// <summary>
        /// Config.xml的路径
        /// </summary>
        /// <returns></returns>
        public static string CategoryConfigPath
        {
            get { return string.Format(@"{0}\Config\Config.xml", RootPath); }
        }

        /// <summary>
        /// 配置
        /// </summary>
        public static CommonHelper.Model.Config Config
        {
            get
            {
                if (null == _config)
                {
                    _config = XCLNetTools.Serialize.XML.DeserializeFromXMLFile<CommonHelper.Model.Config>(CategoryConfigPath);
                }
                return _config;
            }
        }

        /// <summary>
        /// 返回程序集的描述，以便将文字描述放在form的标题栏中
        /// </summary>
        public static string GetCategoryNameInfo(string assemblyName)
        {
            string str = string.Empty;
            if (null != Config && null != Config.CategoryConfig && null != Config.CategoryConfig.CategoryList && Config.CategoryConfig.CategoryList.Count > 0)
            {
                var model = Config.CategoryConfig.CategoryList.Where(k => k.CategoryItemList.Exists(m => string.Equals(m.AssemblyName, assemblyName, StringComparison.CurrentCultureIgnoreCase))).FirstOrDefault();
                if (null != model)
                {
                    str = string.Format("{0}--{1}", model.Name, model.CategoryItemList.Where(m => string.Equals(m.AssemblyName, assemblyName, StringComparison.CurrentCultureIgnoreCase)).First().Name);
                }
            }
            return str;
        }

        #endregion Config.xml
    }
}