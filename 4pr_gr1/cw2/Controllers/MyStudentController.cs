using cw2.Models;
using Microsoft.AspNetCore.Mvc;

namespace cw2.Controllers
{
    public class MyStudentController : Controller
    {
        private readonly StudentsRepo _repo;
        public MyStudentController()
        {
            _repo = new StudentsRepo();
        }
        // GET: MyStudentController
        public ActionResult GetAll()
        {
            var students = _repo.GetStudents();
            return View(students);
        }

    }
}
