using ClassLibrary1.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using WebApplication11.Context;
using WebApplication11.Extensions;

namespace WebApplication11.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly HomeDbContext _context;
        private IWebHostEnvironment _env;
        public CategoryController(HomeDbContext context,IWebHostEnvironment env)
        {
            _context = context;
            _env = env; 
        }

        public IActionResult Index()
        {
            IEnumerable<Category> categories=_context.categories.Where(x=>!x.IsDeleted).ToList();
            return View(categories);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category category)
        {
            if (!ModelState.IsValid)
            {
                return View(category);
            }
            category.Image = category.FormFile.CreateImage(_env.WebRootPath, "img/course");
            _context.categories.Add(category);  
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));   
        }


        public IActionResult Update(int id)
        {
            Category category = _context.categories.Where(x => !x.IsDeleted).FirstOrDefault(x => x.Id == id);

            if (!ModelState.IsValid)
            {
                return View(category);
            }
            if (category == null)
            {
                return NotFound();
            }
            return View(category);


        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(int id, Category category)
        {
            Category updatecategory = _context.categories.Where(x => !x.IsDeleted).FirstOrDefault(x => x.Id == id);
            if (!ModelState.IsValid)
            {
                return View(category);
            }
            if (category == null)
            {
                return NotFound();
            }

            updatecategory.Name = category.Name;
            updatecategory.Description = category.Description;
            updatecategory.Link = category.Link;
            if (category.FormFile!=null)
            {
                updatecategory.Image = category.FormFile.CreateImage(_env.WebRootPath, "img/course");
            }
            _context.SaveChanges();


            return RedirectToAction(nameof(Index));

        }

        public IActionResult Delete(int id)
        {
            Category updatecategory = _context.categories.Where(x => !x.IsDeleted && x.Id == id).FirstOrDefault();

            if (updatecategory == null)
            {
                return NotFound();
            }

            updatecategory.IsDeleted = true;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

    }
}
