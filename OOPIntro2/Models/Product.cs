using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro2.Models
{
    class Product : Base,ILogger
    {
        public Product()
        {

        }

        public Product(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public int Stock { get; set; }

        public DateTime LogAddDate { get; set; }
        public int Status { get; set; }
    }
}
