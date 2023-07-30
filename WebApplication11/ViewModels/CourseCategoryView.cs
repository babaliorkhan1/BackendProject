using ClassLibrary1.Core.Entities;

namespace WebApplication11.ViewModels
{
    public class CourseCategoryView
    {
        public Course Course { get; set; }  
        public IEnumerable<CourseCategory> CourseCategories { get; set; }   
        public IEnumerable<Category>  Categories { get; set; }   
        public IEnumerable<Course>  Courses{ get; set; }   
    }
}
