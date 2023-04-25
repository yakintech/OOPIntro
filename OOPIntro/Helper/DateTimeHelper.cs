using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro.Helper
{
    public class DateTimeHelper
    {
      
   

        public static DateTime GetTomorrow()
        {
            
            return DateTime.Now.AddDays(1);
        }
        public DateTime GetYesterday() 
        {
            return DateTime.Now.AddDays(-1); 
        }

        public DateTime GetYesterday(DateTime dateTime)
        {
            
            return dateTime.AddDays(-1);
        }
    }


}
