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

            string data = File.ReadAllText(Env.fileurl +  "suppliers.json");

            List<Supplier> suppliers = JsonConvert.DeserializeObject<List<Supplier>>(data);

        }
    }
}
