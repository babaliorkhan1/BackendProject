using ClassLibrary1.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using WebApplication11.Context;
using WebApplication11.Extensions;

namespace WebApplication11.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SliderController : Controller
    {
        private  IWebHostEnvironment _env;
        private readonly HomeDbContext _context;
        public SliderController(HomeDbContext context,IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            IEnumerable<Slider> sliders = _context.sliders.Where(x => !x.IsDeleted).ToList();
            return View(sliders);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Slider slider)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            slider.Image = slider.FormFile.CreateImage(_env.WebRootPath, "img/slider/");
            _context.Add(slider);
            _context.SaveChanges();
            
            return RedirectToAction(nameof(Index));
        }
    }
}
