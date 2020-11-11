using OOPIntro2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro2
{
    class Word : IPrint
    {
        public string PageContent { get ; set ; }
        public int PageSize { get ; set ; }


        public string WordVersion { get; set; }
    }
}
