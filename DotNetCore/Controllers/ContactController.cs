using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Concrete;
using BLL.ValidationRules;
using DAL.Concrete.EntityFramework;
using EL.Concrete;
using FluentValidation.Results;

namespace DotNetCore.Controllers
{
    public class ContactController : Controller
    {
        ContactManager cm = new ContactManager(new EfContactRepository());

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Contact p)
        {
            ContactValidator rules = new ContactValidator();
            ValidationResult results = rules.Validate(p);
            if (results.IsValid)
            {
                p.ContactDate2 = DateTime.Parse(DateTime.Now.ToShortDateString());
                p.ContactStatus2 = true;
                cm.ContactAdd(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }

                return View();
            }
        }
    }
}
