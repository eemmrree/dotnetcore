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
    public class RegisterController : Controller
    {
        private WriterManager wm = new WriterManager(new EfWriterRepository());
        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }

        [HttpPost] 
        public IActionResult Index(Writer p)
        {
            p.WriterStatus = true;
            p.WriterAbout = "Deneme";
            wm.WriterAdd(p);
            return RedirectToAction("Index");
        }

    }
}
