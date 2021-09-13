using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL.Concrete
{
    public class About
    {
        [Key]
        public int AboutID { get; set; }
        public int AboutDetail1 { get; set; }
        public int AboutDetail2 { get; set; }
        public int AboutImage1 { get; set; }
        public int AboutImage2 { get; set; }
        public int AboutMapLocation { get; set; }
        public bool AboutStatus { get; set; }
    }
}
