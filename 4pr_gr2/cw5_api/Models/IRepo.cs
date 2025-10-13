using System;

namespace cw5_api.Models;

public interface IRepo
{
    public Student? GetStudent(int id);
    public List<Student> GetAll();
    public void AddStudent(Student student);
    public void UpdateStudent(Student student);
    public void DeleteStudent(int id);
}
