using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Concrete;
using DAL.Concrete.EntityFramework;

namespace DotNetCore.Controllers
{
    public class CommentController : Controller
    {
        private CommentManager cm = new CommentManager(new EfCommentRepository());
        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }

        public PartialViewResult CommentListByBlog(int id)
        {
            
           var values=cm.GetList(id);
            return PartialView(values);
        }
    }
}
