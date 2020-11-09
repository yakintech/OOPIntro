using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro
{
    class Employee
    {
        public Employee(string name, string surname, string email)
        {
            this.Name = name;
            this.SurName = surname;
            this.EMail = email;
        }

        public string Name { get; set; }
        public string SurName { get; set; }
        public string EMail { get; set; }



        public string Phone { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

    }
}
