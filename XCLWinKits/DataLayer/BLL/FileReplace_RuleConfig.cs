namespace DataLayer.BLL
{
    public class FileReplace_RuleConfig
    {
        private DataLayer.DAL.MyContext context = new DataLayer.DAL.MyContext();

        public void Add(DataLayer.Model.FileReplace_RuleConfig model)
        {
            context.FileReplace_RuleConfig.Add(model);
            context.SaveChanges();
        }
    }
}