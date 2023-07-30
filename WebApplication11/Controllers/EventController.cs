using Microsoft.AspNetCore.Mvc;

namespace WebApplication11.Controllers
{
    public class EventController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
