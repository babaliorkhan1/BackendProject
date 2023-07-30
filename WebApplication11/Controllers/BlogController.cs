using ClassLibrary1.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication11.Context;

namespace WebApplication11.Controllers
{
    public class BlogController : Controller
    {
        private readonly HomeDbContext _context;
        public BlogController(HomeDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<Category> categories=_context.categories.Where(x=>!x.IsDeleted).Include(x=>x.CourseCategories).ThenInclude(x=>x.Course).ToList();   
            return View(categories);
        }
        public IActionResult Detail(int id)
        {
            Course course = _context.courses.Include(x=>x.CourseCategories.Where(x=>!x.IsDeleted)).ThenInclude(x=>x.Category).Where(x=>!x.IsDeleted &&x.Id==id).FirstOrDefault();
            return View(course);
        }
    }
}
