using Microsoft.AspNetCore.Mvc;
using pojazdy_sol.Models;

namespace pojazdy_sol.Controllers
{
    public class HomeController : Controller
    {
        private readonly SqlRepo _sqlRepo;
        public HomeController(IConfiguration configuration)
        {
            _sqlRepo = new SqlRepo(configuration);
        }
        // GET: HomeController
        public ActionResult Index()
        {
            var locations = _sqlRepo.GetLocations();
            var alerts = _sqlRepo.GetAlerts();
            var viewModel = new LocationVM
            {
                Locations = locations,
                Alerts = alerts
            };
            _sqlRepo.AddAlert();//losowy wpis do bazy danych, żeby było co wyświetlać
            return View(viewModel);
        }   

    }
}
