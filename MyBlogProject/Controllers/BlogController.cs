using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlogProject.Controllers
{

    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EFBlogRepo());
        public IActionResult Index()
        {
            var values = bm.GetListWithCategory();
            return View(values);
        }
        public IActionResult Create()
        {
            
            return View();
        }
        public IActionResult Detail(int id){
            ViewBag.i = id;
            var values = bm.GetBlogById(id);//var tipi əvəzinə Blog  da yaza bilərik.
            return View(values);
        }
         
      
    }
}
