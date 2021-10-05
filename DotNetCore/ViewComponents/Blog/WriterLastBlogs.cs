using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Concrete;
using DAL.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCore.ViewComponents.Blog
{
    public class WriterLastBlogs:ViewComponent
    {
         BlogManager bm = new BlogManager(new EfBlogRepository());

         public IViewComponentResult Invoke()
         {
             var values = bm.GetBlogListByWriter(3);
             return View(values);
         }
    }
}
