using Microsoft.AspNetCore.Mvc;

namespace cw3_layout.Controllers
{
    public class MyCarsController : Controller
    {
        // GET: MyCarsController
        public ActionResult GetAll()
        {
            return View();
        }

    }
}
