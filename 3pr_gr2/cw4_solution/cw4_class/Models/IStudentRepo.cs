using System;

namespace cw4_class.Models;

public interface IStudentRepo
{
    Student? GetStudent(int id);
    List<Student> GetStudents();
    void AddStudent(Student student);
    void UpdateStudent(Student student);
    void DeleteStudent(int id);
}
