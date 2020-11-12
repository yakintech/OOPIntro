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

    //   Datayı çektiğinde telefonların soluna +90 eklesin ( supplierdaki get set manipüle edilecek) 
    class Address
    {
        public string street { get; set; }
        public string city { get; set; }
        public string region { get; set; }

        string _phone = "";
        public string phone {
            get
            {
                return _phone;
            }
            set
            {
                _phone = "+90" + value;
            } 
        }
    }
  


}
