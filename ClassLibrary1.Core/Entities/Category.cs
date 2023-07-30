using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Core.Entities
{
    public class Category:BaseModel
    {
        
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Link { get; set; }        
        public string? Image { get; set; }    
        [NotMapped]
        public IFormFile? FormFile { get; set; } 
        public List<CourseCategory>? CourseCategories { get; set; }  


    }
}
