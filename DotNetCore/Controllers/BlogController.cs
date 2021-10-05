using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Concrete;
using DAL.Concrete.EntityFramework;

namespace DotNetCore.Controllers
{
    public class BlogController : Controller
    {
        private BlogManager bm = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
           var values = bm.GetBlogList();
            return View(values);
        }

        public IActionResult BlogReadAll(int id)
        {
            ViewBag.i = id;
            var values = bm.GetBlogById(id);
            return View(values);
        }
    }
}
