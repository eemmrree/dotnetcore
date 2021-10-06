using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL.Concrete
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }
        public string ContactUserName { get; set; }
        public string ContactMail { get; set; }
        public string ContactTitle { get; set; }
        public string ContactSubject { get; set; }
        public string ContactMessage { get; set; }

        public bool ContactStatus2 { get; set; }
        public DateTime ContactDate2 { get; set; }
       
    }
}
