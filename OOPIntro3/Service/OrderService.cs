using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro3.Service
{
    class OrderService : BaseService
    {
        public void Add()
        {
            Console.Write("Order add...");
        }

        public override void LogData(string data)
        {
            string path = @"C:\Users\Cagatay\source\repos\OOPIntro\OOPIntro3\Files\orderlog.txt";
            File.AppendAllText(path, data);
            Console.WriteLine("Order datası loglandı");
        }


    }
}
