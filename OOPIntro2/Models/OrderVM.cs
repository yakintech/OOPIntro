using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro2.Models
{
    class OrderVM
    {
        public int id { get; set; }
        public string customerid { get; set; }
        public int employeeId { get; set; }
        public List<Detail> details { get; set; }
        public decimal TotalPrice { get; set; }
    }

    class Detail
    {
        public decimal unitPrice { get; set; }
        public decimal quantity { get; set; }
    }
}
