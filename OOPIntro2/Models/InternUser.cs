using OOPIntro2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro2.Models
{
    class InternUser : Base, IEmployee
    {
        //Interface den gelen özellikler
        public string Name { get; set; }
        public string SurName { get; set; }
        public string EMail { get; set; }
        public string Phone { get; set; }
        public DateTime JoinDate { get; set; }

        //Class ın kendi özellikleri
        public string School { get; set; }
        public bool TaxStatus { get; set; }
    }
}
