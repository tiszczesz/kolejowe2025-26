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
            return View();
        }

    }
}
