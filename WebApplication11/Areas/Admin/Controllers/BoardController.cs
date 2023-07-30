using ClassLibrary1.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using WebApplication11.Context;

namespace WebApplication11.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BoardController : Controller
    {
        private readonly HomeDbContext _context;
        public BoardController(HomeDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<Board> boards=_context.boards.Where(x=>!x.IsDeleted).ToList();  
            return View(boards);
        }
        public IActionResult Create()
        {
            return View();  
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Board board)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            _context.Add(board);
            _context.SaveChanges(); 

            return RedirectToAction(nameof(Index));
        }


        public IActionResult Update(int id)
        {
            Board board = _context.boards.Where(x => !x.IsDeleted).FirstOrDefault(x => x.Id == id);

            if (!ModelState.IsValid)
            {
                return View(board);
            }
            if (board == null)
            {
                return NotFound();
            }
            return View(board);


        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(int id, Board board)
        {
            Board updateboard = _context.boards.Where(x => !x.IsDeleted).FirstOrDefault(x => x.Id == id);
            if (!ModelState.IsValid)
            {
                return View(board);
            }
            if (board == null)
            {
                return NotFound();
            }

            updateboard.Title =board.Title ;
            updateboard.Description = board.Description;
            _context.SaveChanges();


            return RedirectToAction(nameof(Index));

        }

        public IActionResult Delete(int id)
        {
            Board board = _context.boards.Where(x => !x.IsDeleted&&x.Id==id).FirstOrDefault();

            if (board==null)
            {
                return NotFound();
            }

            board.IsDeleted = true;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

    }
}
