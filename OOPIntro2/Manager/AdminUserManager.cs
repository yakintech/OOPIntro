using OOPIntro2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro2.Manager
{
    class AdminUserManager
    {

        public static void Add(AdminUser adminuser)
        {
            //Dışarıdan aldığı objeyi SQL e yolluyor ve insert ediyor
            Console.WriteLine(adminuser.Name + " isimli data eklendi...Eklenen datanın ID numarası: " + adminuser.ID);
        }

        public static void Delete(AdminUser adminuser)
        {
            //aldığı admin user ı silen metot
            Console.WriteLine("Admin user silindi...");

        }

        public static AdminUser GetAdminUser(string id)
        {
            return null;
        }
    }
}
