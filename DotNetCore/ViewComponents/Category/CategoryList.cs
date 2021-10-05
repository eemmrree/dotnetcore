using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Concrete;
using DAL.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCore.ViewComponents.Category
{
    public class CategoryList : ViewComponent
    {
        private CategoryManager cm = new CategoryManager(new EfCategoryRepository());

        public IViewComponentResult Invoke()
        {
            var values = cm.GetList();
            return View(values);
        }
    }
}
