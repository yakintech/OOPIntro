using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro.Models
{
    internal class Product : BaseModel
    {
        readonly string country = "Turkiye";
        void hello()
        {

         IsActive = true;

        }
        public DateTime AddDate { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public Category Category { get; set; }
        public List<int> Points { get; set; }

    }
}
