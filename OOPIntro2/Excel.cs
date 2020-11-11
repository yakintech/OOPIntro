using OOPIntro2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro2
{
    class Excel : IPrint
    {
        public string PageContent { get ; set ; }
        public int PageSize { get ; set ; }
    }
}
