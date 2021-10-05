using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EL.Concrete;

namespace DotNetCore.Models
{
    public class WriterCity
    {
        public List<City> city { get; set; }
        public List<Writer> writers { get; set; }
    }
}
