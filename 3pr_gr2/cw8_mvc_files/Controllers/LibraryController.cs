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
            if(ModelState.IsValid)
            {
               _booksRepo.AddBook(book);
                return RedirectToAction("List");
            }
            return View(book);
            
        }
        public IActionResult DeleteBook(int id)
        {
            _booksRepo.DeleteBook(id);
            return RedirectToAction("List");
        }
        [HttpGet]
        public IActionResult UpdateBook(int id)
        {
            var book = _booksRepo.GetBookById(id);
            if(book == null)
            {
                return RedirectToAction("List");
            }
            return View(book);
        }
        [HttpPost]
        public IActionResult UpdateBook(Book book)
        {
            if (ModelState.IsValid)
            {
                _booksRepo.UpdateBook(book);
                return RedirectToAction("List");
            }
            return View(book);
        }

    }
}
