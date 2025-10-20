using System;

namespace cw4_class.Models;

public class FakeStudentRepo : IStudentRepo
{
    public List<Student> Students { get; set; }
    public FakeStudentRepo()
    {
        Students = new List<Student>
        {
            new Student{Id=1,FirstName="Adam",LastName="Polański",Age=22},
            new Student{Id=2,FirstName="Monika",LastName="Klika",Age=26},
            new Student{Id=3,FirstName="Reneta",LastName="Sałata",Age=45},
            new Student{Id=4,FirstName="Tomasz",LastName="Bomasz",Age=33},
            new Student{Id=5,FirstName="Grażyna",LastName="Sprężyna",Age=56},
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

    public Student? GetStudent(int id)
    {
        throw new NotImplementedException();
    }

    public List<Student> GetStudents()
    {
        throw new NotImplementedException();
    }

    public void UpdateStudent(Student student)
    {
        throw new NotImplementedException();
    }
}
