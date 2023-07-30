using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Core.Entities
{
    public class Social:BaseModel
    { 
        public string Icon { get; set; }    
        public string Link { get; set; }
         public Teacher? Teacher { get; set; }
        public int TeacherId { get; set; }  

    }
}
