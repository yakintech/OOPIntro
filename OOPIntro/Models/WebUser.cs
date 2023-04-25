using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro.Models
{
    internal class WebUser : BaseModel
    {
        public WebUser(string name)
        {
            this.Name= name;
        }

        public WebUser()
        {

        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Country { get; set; } = "Turkey";

    }
}
