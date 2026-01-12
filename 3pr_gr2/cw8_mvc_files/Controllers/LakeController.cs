using Microsoft.AspNetCore.Mvc;

namespace cw8_mvc_files.Controllers
{
    public class LakeController : Controller
    {
        // GET: LakeController
        public ActionResult FishList()
        {
            return View();
        }

    }
}
