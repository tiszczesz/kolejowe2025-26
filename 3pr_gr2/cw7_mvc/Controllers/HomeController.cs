using Microsoft.AspNetCore.Mvc;

namespace cw7_mvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: HomeController
        public ActionResult Index()
        {
            return View();
        }
        public string Hello()
        {
            return "Hello from HomeController";
        }

    }
}
