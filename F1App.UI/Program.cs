using F1App.Business.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1App.UI
{
    class Program
    {
        static void Main(string[] args)
        {
          var data =  F1Manager.GetRaces();
        }
    }
}
