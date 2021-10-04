using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Abstract;
using DAL.Concrete.Repositories;
using EL.Concrete;

namespace DAL.Concrete.EntityFramework
{
    public class EfBlogRepository:GenericRepository<Blog> , IBlogDal
    {
    }
}
