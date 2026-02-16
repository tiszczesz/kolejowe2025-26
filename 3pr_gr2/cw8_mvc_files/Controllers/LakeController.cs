using cw8_mvc_files.Models;
using Microsoft.AspNetCore.Mvc;

namespace cw8_mvc_files.Controllers
{
    public class LakeController : Controller
    {
        private IFishRepo _fishRepo;
        public LakeController(IFishRepo fishRepo)
        {
            _fishRepo = fishRepo;
        }
        // GET: LakeController
        public ActionResult FishList()
        {
            var fishes = _fishRepo.GetFishes();
            return View(fishes);
            
        }
        [HttpGet]
        public IActionResult AddFish()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddFish(Fish fish)
        {
            if(ModelState.IsValid)
            {
                _fishRepo.AddFish(fish);
                return RedirectToAction("FishList");
            }
            return View(fish);
        }   

    }
}
