using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL.Concrete
{
    public class Writer
    {
        [Key]
        public int WriterID { get; set; }
        public int WriterName { get; set; }
        public int WriterAbout { get; set; }
        public int WriterImage { get; set; }
        public int WriterMail { get; set; }
        public int WriterPassword { get; set; }
        public int WriterStatus { get; set; }
    }
}
