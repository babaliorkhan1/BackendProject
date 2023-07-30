using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebApplication11.Context;
using WebApplication11.ViewModels;

namespace WebApplication11.Controllers
{
    public class HomeController : Controller
    {
        private readonly HomeDbContext _context;
        public HomeController(HomeDbContext context) 
        {
            _context= context;  
        }
        public IActionResult Index()
        {
            HomeVm homeVm=new HomeVm();
            homeVm.sliders=_context.sliders.Where(x=>!x.IsDeleted).ToList();
           
            
                homeVm.about = _context.abouts.Where(x => !x.IsDeleted).FirstOrDefault();
          
            homeVm.boards=_context.boards.Where(x=>!x.IsDeleted).ToList();
            homeVm.courses = _context.courses.Where(x => !x.IsDeleted).ToList();
            homeVm.teachers = _context.teachers.Where(x => !x.IsDeleted).Include(x=>x.Socials.Where(x=>!x.IsDeleted)).Include(x=>x.Position)
                .ToList();
        
           
            return View(homeVm);
        }

        
    }
}