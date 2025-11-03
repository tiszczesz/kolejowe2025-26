using cw4_mysql.Models;
using Microsoft.AspNetCore.Mvc;

namespace cw4_mysql.Controllers
{
    public class BooksStoreController : Controller
    {
        private BookRepo _db;
        public BooksStoreController(IConfiguration config)
        {
            _db = new BookRepo(config);
        }

        // GET: BooksStoreController
        public ActionResult Index()
        {
            var books = _db.GetBooks();
            return View(books);
        }
        [HttpGet]
        public IActionResult AddBook()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddBook(Book book)
        {
            if (ModelState.IsValid)
            {
                //zapisanie do bazy
                _db.AddBook(book);
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Delete(int id)
        {
            //usuwanie z bazy
            _db.DeleteBook(id);
            return RedirectToAction("Index");    
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            //pobranie z bazy do edycji
            var bookToEdit = _db.GetBookById(id);
            if (bookToEdit == null)
            {
                //powrot do9 listy gdy nie znaleziono ksiazki do edycji
                return RedirectToAction("Index");
            }
            //wysłanie do widoku modelu do edycji z formularzem
            return View(bookToEdit);
        }
        [HttpPost]
        public IActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                //zapisanie do bazy po edycji
                _db.UpdateBook(book);
                return RedirectToAction("Index");
            }
            return View();
        }   

    }
}
