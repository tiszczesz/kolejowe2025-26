using cw2_ef.Models;
using Microsoft.AspNetCore.Mvc;

namespace cw2_ef.Controllers
{
    public class HomeController : Controller
    {
        private readonly BooksContext _context;
        public HomeController(BooksContext context)
        {
            _context = context;
        }
        // GET: HomeController
        public ActionResult Index()
        {
            var books = _context.Books.ToList();
            return View(books);
        }

    }
}
