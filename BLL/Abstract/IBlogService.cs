using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EL.Concrete;

namespace BLL.Abstract
{
    public interface IBlogService : IGenericService<Blog>
    {
        List<Blog> GetBlogList();

        List<Blog> GetBlogListByWriter(int id);


    }
}
