using ark_zawody.Models;
using Microsoft.AspNetCore.Mvc;

namespace ark_zawody.Controllers
{
    public class HomeController : Controller
    {
        private SqlRepoZawody _sqlRepoZawody;
        public HomeController(IConfiguration configuration)
        {
            _sqlRepoZawody = new SqlRepoZawody(configuration);
        }
        // GET: HomeController
        public ActionResult Index()
        {
            var viewModel = new ViewModel
            {
                LowiskaList = _sqlRepoZawody.GetLowiska()
            };
            return View(viewModel);
        }
        [HttpPost]
        public IActionResult Zgloszenie(ZawodyWedkarskie zawody)
        {
            if (ModelState.IsValid)
            {
                // Process the submitted form data
            }
            return View();
        }

    }
}
