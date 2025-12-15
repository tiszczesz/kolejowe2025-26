using Microsoft.AspNetCore.Mvc;

namespace cw6_mvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: HomeController
        public ActionResult Index()
        {
            return View();
        }
        public string Welcome()
        {
            return "Witamy w ASP.NET MVC!";
        }
        //to nie jest akcja
        private string Secret()
        {
            return "To jest tajna akcja";
        }
        [HttpGet]
        public IActionResult GetData()
        {
            string data = "Dane z metody GetData";
            return View("DataView", data);
            
        }
        [HttpPost]
        public IActionResult PostData(string input)
        {
            string result = $"Otrzymano dane: {input}";
            return View("DataView", result);
        }
    }
}
