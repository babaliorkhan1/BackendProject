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
    public class Course:BaseModel
    {
        public string? Image { get; set; }   
        public string? Image1 { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Link { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string AboutText { get; set; }
        [Required]
        public string AboutCourseTitle { get; set; }
        [Required]
        public string AboutCourseText { get; set; }
        [Required]
        public string AboutApplyTitle { get; set; }
        [Required]
        public string AboutApplyText { get; set; }
        [Required]
        public string AboutCertificationText { get; set; }
        [Required]
        public string AboutCertificationTItle { get; set; }
        [Required]
        public string Start { get; set; }
        [Required]
        public string Duration { get; set; }
        [Required]
        public string ClassDuration { get; set; }
        [Required]
        public string SkillLevel { get; set; }
        [Required]
        public string Language { get; set; }
        [Required]
        public int StudentNumbers { get; set; }
        [Required]
        public int Assetments { get; set; }
        [Required]
        public string Result { get; set; }
        public List<CourseCategory>? CourseCategories { get;set; }
        [NotMapped]
        public IEnumerable<int>? CategoryIds  { get; set; }
        [NotMapped]
        public IFormFile? FormFile { get; set; }
        [NotMapped]
        public IFormFile? FormFile1 { get; set; }

    }
}
