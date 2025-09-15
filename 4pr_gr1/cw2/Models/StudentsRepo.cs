using System;

namespace cw2.Models;

public class StudentsRepo
{
    public List<Student> GetStudents()
    {
        return new List<Student>
        {
            new Student
            {
                Id = 1,
                FirstName = "Jan",
                LastName = "Kowalski",
                BirthDate = new DateTime(2000, 1, 1)
            },
            new Student
            {
                Id = 2,
                FirstName = "Anna",
                LastName = "Nowak",
                BirthDate = new DateTime(1999, 5, 15)
            }
        };
    }
}
