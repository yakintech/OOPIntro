using OOPIntro3.Interface;
using OOPIntro3.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro3.Manager
{
    class LogManager
    {
        public void LogInsert(Base basemodel)
        {
            string path = @"C:\Users\Cagatay\source\repos\OOPIntro\OOPIntro3\Files\systemlog.txt";

            File.AppendAllText(path, "Data loglandı. Tarihi: " + basemodel.AddDate);
        }

        //Dışarıdan class alan aldığı class ın sortnumarası log olarak yazan metot
        public void PrintNumber(ISortable sortobject)
        {
            Console.WriteLine(sortobject.SortNumber);
        }

        void Deneme()
        {
            Order ord = new Order();

            Shipper shipper = new Shipper();

            LogInsert(shipper);

            PrintNumber(shipper);
        }
    }
}
