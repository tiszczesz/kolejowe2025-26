using Microsoft.AspNetCore.Mvc;

namespace cw7_mvc_file.Controllers
{
    public class MoviesLibController : Controller
    {
        // GET: MoviesLibController
        public ActionResult List()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult AddMovie()
        {
            return View();
        }

    }
}
