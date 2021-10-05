using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EL.Concrete;

namespace BLL.Abstract
{
    public interface IBlogService
    {
        void BlogAdd(Blog blog);
        void BlogDelete(Blog blog);
        void BlogUpdate(Blog blog);
        List<Blog> GetList();
        Blog GetById(int id);

        List<Blog> GetBlogList();

        List<Blog> GetBlogListByWriter(int id);


    }
}
