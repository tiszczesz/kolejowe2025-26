using Microsoft.AspNetCore.Mvc;

namespace cw2.Controllers
{
    public class ContactsController : Controller
    {
        // GET: ContactsController
        public ActionResult Index()
        {
            List<string> contacts = new List<string>()
            {
                "Alina","Balina","Michał","Roman","Edek"
            };
            return View(contacts);
        }

    }
}
