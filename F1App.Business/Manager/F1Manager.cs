using F1App.Data.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1App.Business.Manager
{
    public class F1Manager
    {
        static string data = File.ReadAllText(@"C:\Users\Cagatay\source\repos\OOPIntro\F1App.Business\files\2010.json");
        static F1VM f1races = JsonConvert.DeserializeObject<F1VM>(data);


        public static F1VM GetRaces()
        {
            return f1races;
        }
    }
}
