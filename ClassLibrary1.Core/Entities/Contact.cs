using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Core.Entities
{
    public class Contact:BaseModel
    {
       public string Adress { get; set; }   
       public string PhoneNumber { get; set; } 
        public string Relations { get; set; }   


    }
}
