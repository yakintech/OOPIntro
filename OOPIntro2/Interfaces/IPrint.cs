using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro2.Interfaces
{
    interface IPrint
    {
        string PageContent{ get; set; }
        int PageSize { get; set; }
    }
}
