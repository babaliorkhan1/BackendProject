using ClassLibrary1.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using WebApplication11.Context;

namespace WebApplication11.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactController : Controller
    {
        private readonly HomeDbContext _context;
        public ContactController(HomeDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            Contact contact = _context.contacts.Where(x => !x.IsDeleted).FirstOrDefault();   
            return View(contact);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Contact contact)
        {
            if (contact == null)
            {
                return NotFound();
            }
            if (!ModelState.IsValid)
            {
                return View();
            }

            _context.contacts.Add(contact); 
            _context.SaveChanges(); 
            return RedirectToAction(nameof(Index));
        }
    }
}
