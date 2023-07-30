using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Core.Entities
{
    public class CourseCategory:BaseModel
    {
        public int CourseId { get; set; }
        public Course Course { get; set; }  
        public int CategoryId { get; set; } 
        public Category Category{ get; set; }
    }
}
