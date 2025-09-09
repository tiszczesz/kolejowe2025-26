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
        public IActionResult AddNew()
        {
            var book = new Book
            {
                Title = "Nowa Książka",
                Author = "Nowy Autor",
                PublishedDate = DateTime.Now
            };
            _context.Books.Add(book);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Editors()
        {
            var editors = _context.Editors.ToList();
            return View(editors);
        }
        [HttpGet]
        public IActionResult AddEditor()
        {
            //wyswietlenie formularza
            return View();
        }
        [HttpPost]
        public IActionResult AddEditor(Editor editor)
        {
            //zapisanie do bazy danych
            return RedirectToAction(nameof(Editors));
        }

    }
}
