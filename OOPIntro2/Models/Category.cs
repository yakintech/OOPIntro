using OOPIntro2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro2.Models
{
    class Category : Base,ILogger, IPrint
    {
        public string Name { get; set; }
        public string Description { get; set; }


        public DateTime LogAddDate { get ; set ; }
        public int Status { get ; set ; }


        public string PageContent { get; set; }
        public int PageSize { get; set; }
    }
}
