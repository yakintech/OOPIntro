using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro
{
    class Ninja
    {
        public Ninja(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
        public string City { get; set; }

        public void Start()
        {
            Console.WriteLine("Haydi başlayalım! Benim adım " + this.Name.ToUpper());
        }
    }
}
