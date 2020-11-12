using OOPIntro4.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(EnumDepartman.Yazilim.ToString());
            Console.WriteLine(Convert.ToInt32(EnumDepartman.Yazilim));

            Console.ReadLine();


            //https://ergast.com/api/f1/2010.json url den g
        }
    }
}
