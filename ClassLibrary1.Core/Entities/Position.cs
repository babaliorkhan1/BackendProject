using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Core.Entities
{
    public class Position:BaseModel
    {
        public string Name { get; set; }  
        List<Teacher>? Teachers { get; set; }    
    }
}
