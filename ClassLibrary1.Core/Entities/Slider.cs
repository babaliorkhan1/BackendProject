using Microsoft.AspNetCore.Http.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace ClassLibrary1.Core.Entities
{
    public class Slider:BaseModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string? Image{ get; set; }
        public string Link{ get; set; }
        [NotMapped]
        public IFormFile? FormFile { get; set; }

    }
}
