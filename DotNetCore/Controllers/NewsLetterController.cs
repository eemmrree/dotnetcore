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
    public class NewsLetterController : Controller
    {
        NewsLetterManager nl = new NewsLetterManager(new EfNewsLetterRepository());


        [HttpGet]
        public PartialViewResult SubscribeMail()
        {

            return PartialView();
        }
        [HttpPost]
        public IActionResult SubscribeMail(NewsLetter p)
        {
            p.MailStatus = true;
            nl.AddNewsLetter(p);
            return RedirectToAction("Index", "Blog");
        }
    }
}
