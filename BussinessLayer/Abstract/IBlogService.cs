using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface IBlogService
    {
        void Create(Blog blog);
        void Update(Blog blog);
        void Delete(Blog blog);
        List<Blog> GetListAll();
        Blog GetById(int id);
        List<Blog> GetListWithCategory();
        List<Blog> GetBlogById(int id);
        

    }
}
