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
        [HttpGet]
        public IActionResult AddCar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCar(Car car)
        {
            if (ModelState.IsValid)
            {
                _carsRepo = new FileCarsRepo();
                _carsRepo.AddCar(car);
                return RedirectToAction("GetAll");
            }
            return View();
        }
        public IActionResult DeleteCar(int id)
        {
            var _carsRepo = new FileCarsRepo();
            _carsRepo.RemoveCar(id);
            return RedirectToAction("GetAll");
        }
        [HttpGet]
        public IActionResult EditCar(int id)
        {
            var _carsRepo = new FileCarsRepo();
            var carToEdit = _carsRepo.GetCar(id);
            if(carToEdit != null)
            {
                return View(carToEdit);
            }   
            return RedirectToAction("GetAll");
        }
        [HttpPost]
        public IActionResult EditCar(Car car)
        {
            //todo
            return View();
        }

    }
}
