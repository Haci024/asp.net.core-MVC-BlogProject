using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    
   public  interface IGenericDAL<T>where T:class
    {
        void Delete(T t);       
        void Create(T t);
        void Update(T t);
        List<T> GetListAll();
        T GetByID(int id);
        List<T> GetListAll(Expression<Func<T,bool>> filter);

    }
}
