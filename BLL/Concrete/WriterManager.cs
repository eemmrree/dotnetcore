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
    public class WriterManager : IWriterService
    {
        private IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }
        public void WriterAdd(Writer writer)
        {
           _writerDal.Insert(writer);
        }
    }
}
