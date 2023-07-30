using ClassLibrary1.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using WebApplication11.Context;
using WebApplication11.Extensions;

namespace WebApplication11.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutController : Controller
    {
        private IWebHostEnvironment _env;
        private readonly HomeDbContext _context;
        public AboutController(HomeDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            About about = _context.abouts.Where(x => !x.IsDeleted).FirstOrDefault();
            return View(about);
        }

        public IActionResult Create(About about)
        {
            if (!ModelState.IsValid)
            {
                return View(about);
            }
            if (about.FormFile==null)
            {
                ModelState.AddModelError("FormFile", "Image must be one");
                return View(about); 
            }
            about.Image = about.FormFile.CreateImage(_env.WebRootPath,"img/about");
            _context.Add(about);
            _context.SaveChanges(); 
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Update(int id) 
        {
            About about = _context.abouts.Where(x => !x.IsDeleted).FirstOrDefault(x=>x.Id==id);

            if (!ModelState.IsValid) 
            {
                return View(about); 
            }
            if (about==null)
            {
                return NotFound();
            }
            return View(about); 


        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(int id,About about)
        {
            About updateabout = _context.abouts.Where(x => !x.IsDeleted).FirstOrDefault(x => x.Id == id);
            if (!ModelState.IsValid)
            {
                return View(about);
            }
            if (about == null)
            {
                return NotFound();
            }

            updateabout.Title=about.Title;
            updateabout.Description=about.Description;  
            updateabout.Link=about.Link;
            _context.SaveChanges();
          

            return RedirectToAction(nameof(Index));

        }

        public IActionResult Delete(int id)
        {
            About about = _context.abouts.Where(x => !x.IsDeleted && x.Id == id).FirstOrDefault();
            if (about==null)
            {
                return NotFound();
            }
            about.IsDeleted=true;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

    }
}
