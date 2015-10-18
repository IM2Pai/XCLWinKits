using System.Collections.Generic;
using System.Linq;

namespace DataLayer.BLL
{
    public class FileReplace_File
    {
        public void Add(List<DataLayer.Model.FileReplace_File> lst)
        {
            this.Clear();
            if (null != lst && lst.Count > 0)
            {
                using (var context = new DataLayer.DAL.MyDBContext())
                {
                    context.FileReplace_File.AddRange(lst);
                    context.SaveChanges();
                }
            }
        }

        public void Clear()
        {
            using (var context = new DataLayer.DAL.MyDBContext())
            {
                foreach (var m in context.FileReplace_File)
                {
                    context.FileReplace_File.Remove(m);
                }
                context.SaveChanges();
            }
        }

        public List<DataLayer.Model.FileReplace_File> GetAllList()
        {
            using (var context = new DataLayer.DAL.MyDBContext())
            {
                return (from tb in context.FileReplace_File select tb).ToList();
            }
        }
    }
}