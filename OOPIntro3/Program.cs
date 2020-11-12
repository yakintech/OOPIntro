using Newtonsoft.Json;
using OOPIntro3.config;
using OOPIntro3.Models;
using OOPIntro3.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro3
{
    class Program
    {

        static void Main(string[] args)
        {
            OrderService oservice = new OrderService();
            oservice.LogData("10 numaralı sipariş geçildi");

            EmployeeService empservice = new EmployeeService();
            empservice.LogData("Comolokko çalışanı şöyle yaptı böyle yaptı");

            ShipperService shipperservice = new ShipperService();
            shipperservice.LogData("Kargoyu metrobüsle MENTAL olarak yolladım");

            string data = File.ReadAllText(Env.fileurl +  "suppliers.json", Encoding.Default);

            List<Supplier> suppliers = JsonConvert.DeserializeObject<List<Supplier>>(data);


            var data2 = SupplierService.GetSuppliersByCity("Montréal");


            User user = new User();
            user.name = "Doğan";
            user.age = 18;

            User user2 = new User
            {
                name = "Çağatay",
                age = 333,
                city = "Ankara",
                phone = "555-555-55-55"
            };


            UserService.Deneme()
            


        }
    }
}
