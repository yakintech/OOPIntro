using OOPIntro3.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro3.Models
{
    class Order : Base, ISortable
    {
        public string OrderCode { get; set; }
        public DateTime OrderDate { get; set; }
        public string CustomerName { get; set; }


        public int SortNumber { get; set; }
    }
}
