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
    public class NewsLetterManager : INewsLetterService
    {
        INewsLetterDal _newsLetter;

        public NewsLetterManager(INewsLetterDal newsLetter)
        {
            _newsLetter = newsLetter;
        }
        public void AddNewsLetter(NewsLetter newsLetter)
        {
            _newsLetter.Insert(newsLetter);
        }
    }
}
