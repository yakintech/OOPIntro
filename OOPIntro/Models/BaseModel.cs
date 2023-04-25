using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro.Models
{
    internal class BaseModel 
    {
        protected bool IsActive { get; set; }
        public int Id { get; set; } 
    }
}
