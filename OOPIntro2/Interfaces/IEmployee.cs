using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro2.Interfaces
{
    interface IEmployee
    {
        string Name { get; set; }
        string SurName { get; set; }
        string EMail { get; set; }
        string Phone { get; set; }
        DateTime JoinDate { get; set; }
    }
}
