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

    }
}
