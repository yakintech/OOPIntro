using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormSample.Models
{
    internal class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public decimal TaxPrice
        {
            get
            {

                return Price * 1.18M;
            }
        }



    }
}
