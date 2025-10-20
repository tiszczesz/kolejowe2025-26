using cw4_class;
using cw4_class.Models;

IStudentRepo studentRepo = new FakeStudentRepo();
var students = studentRepo.GetStudents();