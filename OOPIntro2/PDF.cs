using OOPIntro2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro2
{
    class PDF : IPrint
    {
        public string PageContent { get; set; }
        public int PageSize { get; set; }


        public string PDFtype { get; set; }

    }
}
