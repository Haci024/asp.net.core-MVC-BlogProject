using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
   public interface ICategoryService
    {
        void Create(Category category);
        void Update(Category category);
        void Delete(Category category);
        List<Category> GetListAll();
        Category GetById(int id);
    }
}
