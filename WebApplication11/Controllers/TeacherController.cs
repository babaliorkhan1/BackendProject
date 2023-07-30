using ClassLibrary1.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication11.Context;

namespace WebApplication11.Controllers
{
    public class TeacherController : Controller
    {
        private readonly HomeDbContext _context;
        public TeacherController(HomeDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<Teacher> teachers=_context.teachers.Where(x=>!x.IsDeleted).Include(x=>x.Socials).Include(x=>x.Position)
                .ToList();        
            return View(teachers);
        }
        public IActionResult Detail(int id)
        {
            Teacher teacher = _context.teachers.Where(x=>!x.IsDeleted &&x.Id==id).Include(x=>x.Position).Include(x=>x.Socials.Where(x=>!x.IsDeleted)).FirstOrDefault();
            return View(teacher);
        }
    }
}
