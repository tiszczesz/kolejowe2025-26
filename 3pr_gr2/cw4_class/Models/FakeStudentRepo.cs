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
        //auto increment Id
        int lastId = Students.Max(x => x.Id);
        student.Id = lastId + 1;
        Students.Add(student);
    }

    public void DeleteStudent(int id)
    {
        Student? studentToRemove = Students.FirstOrDefault(x => x.Id == id);
        if (studentToRemove != null)
        {
            Students.Remove(studentToRemove);
            return;
        } 
    }

    public Student? GetStudent(int id)
    {
        return Students.FirstOrDefault(x => x.Id == id);
    }

    public List<Student> GetStudents()
    {
        return Students;
    }

    public void UpdateStudent(Student student)
    {
        var studentToUpdate = Students.FirstOrDefault(x => x.Id == student.Id);
        if(studentToUpdate != null)
        {
            studentToUpdate.FirstName = student.FirstName;
            studentToUpdate.LastName = student.LastName;
            studentToUpdate.Age = student.Age;
        }
    }
}
