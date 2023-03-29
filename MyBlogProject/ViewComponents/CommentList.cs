using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyBlogProject.Models;

namespace MyBlogProject.ViewComponents
{
    public class CommentList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentValue = new List<UserComment>
            {
               new UserComment
               {
                   Id=1,UserName="Murad"
               },
                new UserComment
               {
                   Id=2,UserName="Nuray"
               },
                 new UserComment
               {
                   Id=3,UserName="Ayse"
               }
            };
            return View(commentValue);
        }

    }
}
