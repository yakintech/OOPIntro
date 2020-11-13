using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1App.Data.Models
{
    public class F1VM
    {
        public MRData MRData { get; set; }
    }

    public class MRData
    {
        public string series { get; set; }
        public string url { get; set; }
        public string limit { get; set; }
        public RaceTable RaceTable { get; set; }
    }

    public class RaceTable
    {
        public string season { get; set; }
    }


}
