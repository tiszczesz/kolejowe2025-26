using cw3_layout.Models;
using Microsoft.AspNetCore.Mvc;

namespace cw3_layout.Controllers
{
    public class MyCarsController : Controller
    {
        public IActionResult Contact()
        {
            return View();
        }
        // GET: MyCarsController
        public ActionResult GetAll()
        {
            var carsRepo = new FakeCarsRepo();
            var cars = carsRepo.Cars;
            return View(cars);
        }

    }
}
