using Microsoft.AspNetCore.Mvc;

namespace cw8_mvc_files.Controllers
{
    public class LibraryController : Controller
    {
        // GET: LibraryController
        public ActionResult List()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddBook()
        {
            return View();
        }

    }
}
