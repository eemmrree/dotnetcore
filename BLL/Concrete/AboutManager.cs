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
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }
        public List<About> GetList()
        {
            return _aboutDal.GetListAll();
        }
    }
}
