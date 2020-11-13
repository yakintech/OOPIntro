using OOPIntro4.Enums;
using OOPIntro4.Manager;
using OOPIntro4.Models;
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

            //Console.WriteLine(EnumDepartman.Yazilim.ToString());
            //Console.WriteLine(Convert.ToInt32(EnumDepartman.Yazilim));

            //Console.ReadLine();


            //Repository<Category> rpcat = new Repository<Category>();
            //Repository<Product> rpproduct = new Repository<Product>();


            Print print = new Print();

            print.PrintData<string>("Çağatay");
            print.PrintData<int>(6);


            Product product = new Product();
            product.Data = 5;
            product.Data = "blabla";


            var ornekdata = new
            {
                ad = "Çağatay",
                yas = 33,
                adres = new
                {
                    sokak = "falan filan"
                }
            };



        }
    }
}
