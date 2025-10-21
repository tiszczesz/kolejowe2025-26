using Microsoft.AspNetCore.Mvc;

namespace cw4_mysql.Controllers
{
    public class BooksStoreController : Controller
    {
        // GET: BooksStoreController
        public ActionResult Index()
        {
            return View();
        }

    }
}
