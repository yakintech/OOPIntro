using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro2.Models
{
    interface ILogger
    {
         DateTime LogAddDate { get; set; }
         int Status { get; set; }
    }
}
