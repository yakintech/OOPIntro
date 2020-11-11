using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro3.Models
{
    class Supplier
    {
        public int id { get; set; }
        public string companyName { get; set; }
        public string contactName { get; set; }
        public Address address { get; set; }
    }

    class Address
    {
        public string street { get; set; }
        public string city { get; set; }
        public string region { get; set; }
        public string phone { get; set; }
    }
}
