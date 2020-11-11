using OOPIntro3.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro3.Service
{
    public class BaseService
    {
        public virtual void LogData(string data)
        {
            string path = @"C:\Users\Cagatay\source\repos\OOPIntro\OOPIntro3\Files\log.txt";
            File.AppendAllText(path, data);
            Console.WriteLine("Data loglandı");
        }



    }
}