using OOPIntro3.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro3.Models
{
    class Shipper :Base   ,  ISortable
    {
        public string ShipCode { get; set; }
        public DateTime ShipDate { get; set; }
        public int SortNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
