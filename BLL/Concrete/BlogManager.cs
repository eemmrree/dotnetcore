using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Abstract;
using DAL.Abstract;
using EL.Concrete;

namespace BLL.Concrete
{
    public class BlogManager : IBlogService
    {
        private readonly IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }
        
        public List<Blog> GetList()
        {
            return _blogDal.GetListAll();
        }

        public List<Blog> GetWithCategoryByWriter(int id)
        {
            return _blogDal.GetListWithCategoryByWriter(id);
        }
        public List<Blog> GetLast3Blogs()
        {
            return _blogDal.GetListAll().Take(3).ToList();
        }

        public List<Blog> GetBlogById(int id)
        {
            return _blogDal.GetListAll(x => x.BlogID == id);
        }

        public Blog GetById(int id)
        {
            return _blogDal.GetById(id);
        }

        public List<Blog> GetBlogList()
        {
            return _blogDal.GetListWithCategory();
        }

        public List<Blog> GetBlogListByWriter(int id)
        {
            return _blogDal.GetListAll(x => x.WriterID == id);
        }

        public void Add(Blog t)
        {
            _blogDal.Insert(t);
        }

        public void Delete(Blog t)
        {
            _blogDal.Delete(t);
        }

        public void Update(Blog t)
        {
            _blogDal.Update(t);
        }
    }
}
