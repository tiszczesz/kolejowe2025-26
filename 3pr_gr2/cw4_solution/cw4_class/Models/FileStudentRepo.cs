using System;

namespace cw4_class.Models;

public class FileStudentRepo : IStudentRepo
{
    public List<Student> Students { get; set; }
    public FileStudentRepo(string filePath)
    {
        Students = LoadStudentsFromFile(filePath);
    }
    private List<Student> LoadStudentsFromFile(string filePath)
    {
        var students = new List<Student>();
        var lines = File.ReadAllLines(filePath);
        foreach (var line in lines)
        {
            var parts = line.Split(';');
            if (parts.Length == 4)
            {
                var student = new Student
                {
                    Id = Convert.ToInt32(parts[0]),
                    FirstName = parts[1],
                    LastName = parts[2],
                    Age = Convert.ToInt32(parts[3])
                };
                students.Add(student);
            }
        }
        return students;
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
        return Students;
    }

    public void UpdateStudent(Student student)
    {
        throw new NotImplementedException();
    }
}
