using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication11.Context;
using WebApplication11.ViewModels;

namespace WebApplication11.Controllers
{
    public class AboutController : Controller
    {
        private readonly HomeDbContext _context;
        public AboutController(HomeDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeVm homeVm = new HomeVm();



            homeVm.about = _context.abouts.Where(x => !x.IsDeleted).FirstOrDefault();
            homeVm.teachers = _context.teachers.Where(x => !x.IsDeleted).Include(x => x.Socials.Where(x => !x.IsDeleted)).Include(x => x.Position)
                .ToList();

            return View(homeVm);
        }
    }
}
