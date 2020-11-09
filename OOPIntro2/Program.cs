using OOPIntro2.Manager;
using OOPIntro2.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro2
{
    class Program
    {
        static void Main(string[] args)
        {
            AdminUser adminuser = new AdminUser();
            adminuser.Name = "Çağatay";
            adminuser.SurName = "Yıldız";
            adminuser.Phone = "5437331470";
            adminuser.EMail = "cagatay.yildiz@bilgeadam.com";

            AdminUserManager.Add(adminuser);


            Console.ReadLine();
        }
    }
}
