using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro2.Models
{
    class ProductVM
    {
        public int id { get; set; }
        public int unitsInStock { get; set; }
        public string name { get; set; }
        public int supplierId { get; set; }
        public int categoryId { get; set; }
        public double unitPrice { get; set; }
        public CategoryVM category { get; set; }

    }
}
