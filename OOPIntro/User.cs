using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro
{
    class User
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Phone { get; set; }
        public string EMail { get; set; }

        //Kullanıcı eğer bir ülke set etmezse ben default olarak Türkiye atamak istiyorum.
        string _country = "Türkiye";
        public string Country {
            get
            {
                return _country;
            }
            set
            {
                _country = value;
            } 
        }



        private string _hashcode = Guid.NewGuid().ToString();
        public string Hashcode {
            get
            {
                return _hashcode;
            }
        }

    }
}
