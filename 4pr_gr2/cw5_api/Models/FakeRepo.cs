using System;

namespace cw5_api.Models;

public class FakeRepo : IRepo
{
    private List<Student> _students;
    public FakeRepo()
    {
        _students = new List<Student>
        {
            new Student { Id = 1, FirstName = "Jan", LastName = "Kowalski", BirthDate = new DateTime(2000, 1, 1) },
            new Student { Id = 2, FirstName = "Anna", LastName = "Nowak", BirthDate = new DateTime(1999, 5, 15) },
            new Student { Id = 3, FirstName = "Piotr", LastName = "Zieliński", BirthDate = new DateTime(2001, 3, 22) }
        };
    }
    public void AddStudent(Student student)
    {
        throw new NotImplementedException();
    }

    public void DeleteStudent(int id)
    {
        throw new NotImplementedException();
    }

    public List<Student> GetAll()
    {
        throw new NotImplementedException();
    }

    public Student? GetStudent(int id)
    {
        throw new NotImplementedException();
    }

    public void UpdateStudent(Student student)
    {
        throw new NotImplementedException();
    }
}
