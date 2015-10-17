using System.Data.Entity;

namespace DataLayer.DAL
{
    public class MyContext : DbContext
    {
        public MyContext() : base("XCLWinKitsDB")
        {
        }

        public DbSet<DataLayer.Model.FileReplace_RuleConfig> FileReplace_RuleConfig { get; set; }
    }
}