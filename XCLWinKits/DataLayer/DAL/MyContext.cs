using System.Data.Entity;

namespace DataLayer.DAL
{
    public class MyDBContext : DbContext
    {
        public MyDBContext() : base("XCLWinKitsDB")
        {
        }

        /// <summary>
        /// 表名不要自动生成复数
        /// </summary>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();
        }

        public DbSet<DataLayer.Model.FileReplace_RuleConfig> FileReplace_RuleConfig { get; set; }

        public DbSet<DataLayer.Model.FileReplace_File> FileReplace_File { get; set; }

        public DbSet<DataLayer.Model.UserSetting> UserSetting { get; set; }
    }
}