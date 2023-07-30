using ClassLibrary1.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using WebApplication11.Context;

namespace WebApplication11.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PositionController : Controller
    {
        private readonly HomeDbContext _context;
        public PositionController(HomeDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<Position> positions =_context.positions.Where(x=>!x.IsDeleted).ToList();    
            return View(positions);
        }
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Position position)
        {
            if (!ModelState.IsValid)
            {
                return View(position);
            }
            _context.positions.Add(position);   
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));   
        }
    }
}
