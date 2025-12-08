
using cw7_mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace cw7_mvc.Controllers
{
    public class MyUserController : Controller
    {
        public User CurrentUser { get; set; }
        // GET: MyUserController
        public ActionResult Info()
        {
            CurrentUser = new User
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                BirthDate = new DateTime(1990, 1, 1)
            };
            return View("ShowUser",CurrentUser);
        }
        [HttpGet] //OnGet
        public ActionResult CreateUser()
        {
            return View();
        }
        [HttpPost] //OnPost
        public ActionResult CreateUser(User user)
        {
            // In a real application, you would save the user to a database here.
            return View("ShowUser", user);
        }

    }
}
