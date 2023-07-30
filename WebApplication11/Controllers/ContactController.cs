using ClassLibrary1.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using WebApplication11.Context;

namespace WebApplication11.Controllers
{
    public class ContactController : Controller
    {
        private readonly HomeDbContext _context;
        public ContactController(HomeDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            Contact contact=_context.contacts.FirstOrDefault();
            return View(contact);
        }
    }
}
