using OOPIntro3.Service;
using System;
using System.Collections.Generic;
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


        }
    }
}
