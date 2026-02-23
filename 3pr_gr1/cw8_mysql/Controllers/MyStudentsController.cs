using Microsoft.AspNetCore.Mvc;

namespace cw8_mysql.Controllers
{
    public class MyStudentsController : Controller
    {
        // GET: MyStudentsController
        public ActionResult List()
        {
            return View();
        }

    }
}
