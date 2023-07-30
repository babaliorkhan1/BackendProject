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
    public class Teacher:BaseModel
    {
        [Required]
        public string FullName { get; set; }
        public string? Image { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]

        public string AboutText { get; set; }
        [Required]

        public string Degree { get; set; }
        [Required]
        public string Experience { get; set; }
        [Required]
        public string Hobbies { get; set; }
        [Required]
        public string Faculty { get; set; }
        [Required]
        public int? PositionId { get; set; }
        public Position? Position { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Number { get; set; }
        [Required]
        public string Skype { get; set; }  
            
        public List<Social>? Socials { get; set; }
        [NotMapped]
        public List<int>? Percents { get; set; }    
        [NotMapped]
        public IFormFile? FormFile { get; set; } 
    }
}
