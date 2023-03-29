using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDAL _IblogDAL;
        public BlogManager(IBlogDAL blogDAL)
        {
            _IblogDAL = blogDAL;
        }
        public void Create(Blog blog)
        {
            _IblogDAL.Create(blog);
        }

        public void Delete(Blog blog)
        {
            _IblogDAL.Delete(blog);
        }

        public List<Blog> GetListWithCategory()
        {
            return _IblogDAL.GetListWithCategory();
        }

        public Blog GetById(int id)
        {
            return _IblogDAL.GetByID(id);
        }

        public List<Blog> GetListAll()
        {
            return _IblogDAL.GetListAll();
        }
        public List<Blog> GetBlogById(int id)
        {
            return _IblogDAL.GetListAll(x=>x.Id==id);
        }

        public void Update(Blog blog)
        {
            _IblogDAL.Update(blog);
        }
    }
}
