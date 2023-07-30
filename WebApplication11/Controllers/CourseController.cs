using ClassLibrary1.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication11.Context;
using WebApplication11.ViewModels;

namespace WebApplication11.Controllers
{
    public class CourseController : Controller
    {
        private readonly HomeDbContext _context;
        public CourseController(HomeDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            CourseView course=new CourseView(); 
            course.courses=_context.courses.Where(x=>!x.IsDeleted).ToList();    
            return View(course);
        }
        public IActionResult Detail(int id)
        {
            CourseCategoryView course=new CourseCategoryView();
            course.Course = _context.courses.Where(x => !x.IsDeleted && x.Id == id).FirstOrDefault();
            course.Categories = _context.categories.Where(x => !x.IsDeleted).ToList();
            course.Courses = _context.courses.Where(x => !x.IsDeleted).ToList();
            course.CourseCategories = _context.courseCategories.Include(x=>x.Course)
                .Where(x => !x.IsDeleted).ToList();
            return View(course);
        }
    }
}
