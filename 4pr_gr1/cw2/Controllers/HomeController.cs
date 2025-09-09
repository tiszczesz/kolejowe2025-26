using Microsoft.AspNetCore.Mvc;

namespace cw2.Controllers
{
    public class HomeController : Controller
    {
        // GET: HomeController
        public ActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            string info = "to jest informacja z akcji About";
            ViewBag.info = info;
            string info2 = "to jest przez model";
            return View("OtherAbout", info2);
        }

    }
}
