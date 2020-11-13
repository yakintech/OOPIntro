using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro4.Models
{
    class Product : Base
    {
        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public dynamic Data { get; set; }

    }
}
