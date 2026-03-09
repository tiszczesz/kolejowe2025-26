using cw8_mysql.Models;
using Microsoft.AspNetCore.Mvc;

namespace cw8_mysql.Controllers
{
    public class MyStudentsController : Controller
    {
        private StudentRepo _studentRepo;
        public MyStudentsController(IConfiguration configuration)
        {
            _studentRepo = new StudentRepo(configuration);
        }
        // GET: MyStudentsController
        public ActionResult List()
        {
            var students = _studentRepo.GetStudents();
            return View(students);
        }
        [HttpGet]
        public ActionResult AddStudent()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddStudent(Student student)
        {
            if (ModelState.IsValid)
            {
                _studentRepo.AddStudent(student);
                return RedirectToAction("List");
            }
            return View(student);
        }
        public ActionResult DeleteStudent(int id)
        {
            _studentRepo.DeleteStudent(id);
            return RedirectToAction("List");
        }

    }
}
