using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    public class UserSetting
    {
        /// <summary>
        /// 用户配置ID
        /// </summary>
        [Key]
        public int UserSettingID { get; set; }
        /// <summary>
        /// FileReplace 配置项
        /// </summary>
        public string FileReplaceSetting { get; set; }
    }


    [Serializable]
    public class FileReplaceSetting
    {
        /// <summary>
        /// 已选规则
        /// </summary>
        public List<int> RuleConfigIds { get; set; }
        /// <summary>
        /// 输出目录
        /// </summary>
        public string OutPutPath { get; set; }
        /// <summary>
        /// 前缀名
        /// </summary>
        public string PrefixName { get; set; }
        /// <summary>
        /// 后缀名
        /// </summary>
        public string SuffixName { get; set; }
    }
}
