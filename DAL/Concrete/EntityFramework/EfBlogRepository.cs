using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Abstract;
using DAL.Concrete.Repositories;
using EL.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DAL.Concrete.EntityFramework
{
    public class EfBlogRepository:GenericRepository<Blog> , IBlogDal
    {
        public List<Blog> getListWithCategory()
        {
            using (var c = new Context())
            {
                return c.Blogs.Include(x => x.Category).ToList();
            }
           
        }
    }
}
