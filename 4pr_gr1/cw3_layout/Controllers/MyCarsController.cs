using cw3_layout.Models;
using Microsoft.AspNetCore.Mvc;

namespace cw3_layout.Controllers
{
    public class MyCarsController : Controller
    {
        private ICarsRepo _carsRepo;
        public IActionResult Contact()
        {
            return View();
        }
        // GET: MyCarsController
        public ActionResult GetAll()
        {
            _carsRepo = new FileCarsRepo();
            var cars = _carsRepo.Cars;
            return View(cars);
        }
        public IActionResult AddCar()
        {
            var car = new Car
            {
                Brand = "Trabant",
                Model = "Trabant 601",
                Year = 2020
            };
            _carsRepo = new FileCarsRepo();
            _carsRepo.AddCar(car);
            return RedirectToAction("GetAll");
        }

    }
}
