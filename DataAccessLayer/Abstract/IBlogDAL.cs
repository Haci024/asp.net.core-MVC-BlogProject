using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
namespace DataAccessLayer.Abstract
{
   public interface IBlogDAL:IGenericDAL<Blog>
    {
        List<Blog> GetListWithCategory();//Xəbərlərlə Kategoriyalar arasında əlaqə

        
    }
}
