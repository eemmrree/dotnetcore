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
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DotNetCore.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        private readonly BlogManager _bm = new(new EfBlogRepository());
        private readonly CategoryManager _cm = new(new EfCategoryRepository());
        public IActionResult Index()
        {
           var values = _bm.GetBlogList();
            return View(values);
        }

        public IActionResult BlogReadAll(int id)
        {
            ViewBag.i = id;
            var values = _bm.GetBlogById(id);
            return View(values);
        }

        public IActionResult BlogListByWriter()
        {
            var values=_bm.GetWithCategoryByWriter(3);
            return View(values);
        }
        [HttpGet]
        public IActionResult BlogAdd()
        {
            
            var valuesItems = (from c in _cm.GetList()
                select new SelectListItem
                {
                    Text = c.CategoryName,
                    Value = c.CategoryID.ToString()
                }).ToList();
            ViewBag.cv = valuesItems;
            return View();
        }
        [HttpPost]
        public IActionResult BlogAdd(Blog p)
        {
            var bv = new BlogValidator();
            var results = bv.Validate(p);
            if (results.IsValid)
            {
                p.BlogStatus = true;
                p.BlogCreatedDate=DateTime.Parse(DateTime.Now.ToShortDateString());
                p.WriterID = 3;
                _bm.Add(p);
                return RedirectToAction("BlogListByWriter", "Blog");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
            }
            return View();
        }

        public IActionResult BlogDelete(int id)
        {
            var blogValue = _bm.GetById(id);
            _bm.Delete(blogValue);
            return RedirectToAction("BlogListByWriter", "Blog");
        }

        [HttpGet]
        public IActionResult BlogEdit(int id)
        {
            var valuesItems = (from c in _cm.GetList()
                select new SelectListItem
                {
                    Text = c.CategoryName,
                    Value = c.CategoryID.ToString()
                }).ToList();
            ViewBag.cv = valuesItems;
            var blogValue = _bm.GetById(id);
            return View(blogValue);
        }

        [HttpPost]
        public IActionResult BlogEdit(Blog p)
        {
            p.WriterID = 3;
            p.BlogCreatedDate=DateTime.Parse(DateTime.Now.ToShortDateString());
            p.BlogStatus = true;
            _bm.Update(p);
            return RedirectToAction("BlogListByWriter", "Blog");
        }
    }
}
