using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro3.Models
{
    class User
    {
        public User(string name, string city)
        {
            this.name = name;
            this.city = city;
        }

        public User()
        {

        }

        public string name { get; set; }
        public string city { get; set; }
        public int age { get; set; }
        public string phone { get; set; }



    }
}
