using cw9_mysql.Models;
using Microsoft.AspNetCore.Mvc;

namespace cw9_mysql.Controllers
{
    public class MyUsersController : Controller
    {
        private readonly UsersRepo _usersRepo;
        public MyUsersController(IConfiguration configuration)
        {
            _usersRepo = new UsersRepo(configuration);
        }
        // GET: MyUsersController
        public ActionResult List()
        {
            var users = _usersRepo.GetUsers();
            return View(users);
        }

    }
}
