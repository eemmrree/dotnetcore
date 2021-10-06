using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Concrete;
using DAL.Concrete.EntityFramework;
using EL.Concrete;

namespace DotNetCore.Controllers
{
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager(new EfCommentRepository());

        [HttpGet]
        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }
        [HttpPost]
        public IActionResult PartialAddComment(Comment p)
        {
            p.CommentDate=DateTime.Parse(DateTime.Now.ToShortDateString());
            p.CommentStatus = true;
            p.BlogID = 2; 
            cm.CommentAdd(p);
            return RedirectToAction("Index", "Blog");
        }

        public PartialViewResult CommentListByBlog(int id)
        {
            
           var values=cm.GetList(id);
            return PartialView(values);
        }
    }
}
