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
    public class About : BaseModel
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public string? Image { get; set; }
        [Required]

        public string Link { get; set; }
        [NotMapped]
        public IFormFile? FormFile { get; set; }
    }
}
