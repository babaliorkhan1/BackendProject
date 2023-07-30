using ClassLibrary1.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using WebApplication11.Context;

namespace WebApplication11.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SocialController : Controller
    {
        private readonly HomeDbContext _context;
        public SocialController(HomeDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<Social> socials=_context.socials.Where(x=>!x.IsDeleted).ToList();   
            return View(socials);
        }

        public IActionResult Create()
        {
            ViewBag.Teachers=_context.teachers.Where(x=>!x.IsDeleted).ToList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Social social)
        {
            ViewBag.Teachers = _context.teachers.Where(x => !x.IsDeleted).ToList();
            if (!ModelState.IsValid)
            {
                return View(social);
            }

            _context.socials.Add(social);   
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
