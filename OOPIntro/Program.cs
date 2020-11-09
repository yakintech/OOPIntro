using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOPIntro
{
    class Program
    {
        static void Main(string[] args)
        {
               
            //değer atama işlemi propa değer SET ediyor
            User user = new User();
            user.Name = "Çağatay";
            user.SurName = "Yıldız";
            user.Phone = "5437331470";
            user.EMail = "cagatay.yildiz@bilgeadam.com";
            user.Country = "ABD";
            // user.Hashcode = "lkngu1e12ras";

            //get işlemi ise property üzerindeki değeri okumak  

            User user2 = new User
            {
                Name = "Şoko",
                Country = "Almanya",
                Phone = "5437331470"
            };
            //Console.WriteLine(user.Hashcode);
            //Console.WriteLine(user2.Hashcode);


            Employee employee = new Employee("Çağatay", "Yıldız", "cagatay.yildiz@bilgeadam.com");


            Ninja ninja = new Ninja("Şokobons");
            //ninja.Start();


            NinjaManager.Add();

            Math.Sin(90);


            Console.ReadLine();
            Console.WriteLine();

                 
            


        }
    }

}
