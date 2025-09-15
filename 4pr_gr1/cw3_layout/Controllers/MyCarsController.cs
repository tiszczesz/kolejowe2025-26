using Microsoft.AspNetCore.Mvc;

namespace cw3_layout.Controllers
{
    public class MyCarsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        // GET: MyCarsController
        public ActionResult GetAll()
        {
            return View();
        }

    }
}
