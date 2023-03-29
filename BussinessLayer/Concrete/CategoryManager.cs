using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDAL _categoryDAL;
        public CategoryManager(ICategoryDAL categoryDAL)
        {
            _categoryDAL = categoryDAL;//
        }
        public void Create(Category category)
        {
            _categoryDAL.Create(category);

            
        }

        public void Delete(Category category)
        {
            _categoryDAL.Delete(category);
            
        }

        public Category GetById(int id)
        {
            return _categoryDAL.GetByID(id);
        }

        public List<Category> GetListAll()
        {
            return _categoryDAL.GetListAll();
        }

        public void Update(Category category)
        {
            _categoryDAL.Update(category);
        }
    }
}
