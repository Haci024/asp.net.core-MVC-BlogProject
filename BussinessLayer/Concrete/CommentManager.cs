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
    public class CommentManager : ICommentService
    {
        ICommentDAL _commentDAL;
        public CommentManager(ICommentDAL commentDAL)
        {
            _commentDAL = commentDAL;
        }

     

        public void CommentAdd(Comment comment)
        {
            _commentDAL.Create(comment);
        }


        public List<Comment> GetList(int id)
        {

            return _commentDAL.GetListAll(x=>x.Id==id);
        }

    
    }
}
