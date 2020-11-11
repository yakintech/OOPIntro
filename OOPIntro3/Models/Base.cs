using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro3.Models
{
    class Base
    {
        string _guid = Guid.NewGuid().ToString();
        public string ID
        {
            get
            {
                return _guid;
            }
        }

        DateTime _addDate = DateTime.Now;
        public DateTime AddDate
        {
            get
            {
                return _addDate;
            }
        }
    }
}
