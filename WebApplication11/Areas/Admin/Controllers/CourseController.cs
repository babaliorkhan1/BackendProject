using ClassLibrary1.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication11.Context;
using WebApplication11.Extensions;

namespace WebApplication11.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CourseController : Controller
    {
        private IWebHostEnvironment _env;
        private readonly HomeDbContext _context;
        public CourseController(HomeDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            IEnumerable<Course> courses = _context.courses.Where(x => !x.IsDeleted).Include(x=>x.CourseCategories).ThenInclude(x=>x.Category).ToList();
            
            return View(courses);
        }

        public IActionResult Create()
        {
            ViewBag.Categories = _context.categories.Where(x => !x.IsDeleted).ToList();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Course course)
        {
            if (!ModelState.IsValid)
            {
                return View(course);
            }
        
            foreach (var item in course.CategoryIds)
            {
                ViewBag.Categories = _context.categories.Where(x => !x.IsDeleted).ToList();
                if (!_context.categories.Any(x=>x.Id==item))
                {
                    ModelState.AddModelError("", "Result is not found");
                    return View(course);  
                }
                CourseCategory courseCategory = new CourseCategory
                {
                      Course=course,
                      CategoryId=item
                };
                _context.Add(courseCategory);
            }

            course.Image = course.FormFile.CreateImage(_env.WebRootPath,"img/course");
            course.Image1 = course.FormFile1.CreateImage(_env.WebRootPath,"img/course");
            _context.Add(course);
            _context.SaveChanges(); 
               
            return RedirectToAction(nameof(Index));   
        }
        public IActionResult Update(int id)
        {
            ViewBag.Categories = _context.categories.Where(x => !x.IsDeleted).ToList();
            Course? updatecourse = _context.courses.Where(x => !x.IsDeleted && x.Id == id).Include(x => x.CourseCategories).ThenInclude(x => x.Category).FirstOrDefault();

            if (updatecourse == null)
            {
                return NotFound();
            }
            return View(updatecourse);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(int id,Course course)
        {
            ViewBag.Categories = _context.categories.Where(x => !x.IsDeleted).ToList();
            Course? updatecourse = _context.courses.Where(x => !x.IsDeleted && x.Id == id).Include(x=>x.CourseCategories).ThenInclude(x=>x.Category).FirstOrDefault();
            if (updatecourse == null) 
            {
                return NotFound();
            }
            updatecourse.Description = course.Description;  
            updatecourse.AboutCourseTitle = course.AboutCourseTitle;    
            updatecourse.AboutCourseText = course.AboutCourseText;  
            updatecourse.AboutText= course.AboutText;   
            updatecourse.AboutApplyText = course.AboutApplyText;    
            updatecourse.AboutApplyTitle = course.AboutApplyTitle;  
            updatecourse.AboutCertificationTItle = course.AboutCertificationTItle;  
            updatecourse.AboutCertificationText= course.AboutCertificationText; 
            updatecourse.Start= course.Start;
            updatecourse.StudentNumbers= course.StudentNumbers; 
            updatecourse.ClassDuration= course.ClassDuration;   
            updatecourse.Duration= course.Duration; 
            updatecourse.Assetments= course.Assetments; 
            updatecourse.SkillLevel= course.SkillLevel; 
            updatecourse.Result= course.Result; 
            updatecourse.Name= course.Name; 
            updatecourse.Assetments=course.Assetments;  
            updatecourse.Language= course.Language;

            if (course.FormFile!=null &&course.FormFile1!=null)
            {
                updatecourse.Image = course.FormFile.CreateImage(_env.WebRootPath, "img/course");
                updatecourse.Image1 = course.FormFile1.CreateImage(_env.WebRootPath, "img/course");
            }

         
            
                List<CourseCategory> courseCategories = _context.courseCategories.Where(x => x.CourseId==id && !course.CategoryIds.Contains(x.CategoryId)).ToList();
            _context.courseCategories.RemoveRange(courseCategories);

            foreach ( var item in course.CategoryIds)
            {
                if (_context.courseCategories.Where(x=>x.CourseId==id &&x.CategoryId==item).Count()>0)
                {
                    continue;
                }
                CourseCategory courseCategory = new CourseCategory
                {
                    Course=course,
                    CategoryId=item
                };
                _context.courseCategories.Add(courseCategory);
            }
            
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int id)
        {
            Course course = _context.courses.Where(x => !x.IsDeleted).FirstOrDefault();
            if (course == null)
            {
                return NotFound();
            }
            course.IsDeleted=true;
            _context.SaveChanges(); 
            return RedirectToAction(nameof(Index)); 
        }
    }
}
