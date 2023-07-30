using ClassLibrary1.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication11.Context;
using WebApplication11.Extensions;

namespace WebApplication11.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TeacherController : Controller
    {
        private readonly HomeDbContext _context;
        private IWebHostEnvironment _env;
        public TeacherController(HomeDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env; 
        }
        public IActionResult Index()
        {
            IEnumerable<Teacher> teachers=_context.teachers.Where(x=>!x.IsDeleted).ToList();    
            return View(teachers);
        }

        public IActionResult Create()
        {
            ViewBag.Positions=_context.positions.Where(x=>!x.IsDeleted).ToList();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Teacher teacher)
        {
            ViewBag.Positions = _context.positions.Where(x => !x.IsDeleted).ToList();
            if (!ModelState.IsValid)
            {
                return View(teacher);
            }

            teacher.Image = teacher.FormFile.CreateImage(_env.WebRootPath,"img/teacher");
            _context.Add(teacher);
            _context.SaveChanges(); 
            return RedirectToAction(nameof(Index));
        }
    }
}
