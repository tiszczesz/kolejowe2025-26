using cw8_mvc_files.Models;
using Microsoft.AspNetCore.Mvc;

namespace cw8_mvc_files.Controllers
{
    public class LibraryController : Controller
    {
        private IBooksRepo _booksRepo;

        public LibraryController(IBooksRepo booksRepo)
        {
            _booksRepo = booksRepo;
        }
        // GET: LibraryController
        public ActionResult List()
        {
            var books = _booksRepo.GetBooks();
            return View(books);
        }
        [HttpGet]
        public IActionResult AddBook()
        {
            //aby wywołaC widok z formularzem
            return View();
        }
        [HttpPost]
        public IActionResult AddBook(Book book)
        {
            //aby odebrać dane z formularza
            //dodać książkę do repozytorium
            _booksRepo.AddBook(book);
            return RedirectToAction("List");
        }

    }
}
