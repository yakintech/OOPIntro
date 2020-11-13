using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPUygulamaList.Models
{
    public class Order : Base
    {
        public int id { get; set; }
        public string orderaddress { get; set; }
        public string city { get; set; }
        public string description { get; set; }

    }
}
