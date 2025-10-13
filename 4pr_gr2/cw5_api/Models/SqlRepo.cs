using System;
using Microsoft.Data.Sqlite;

namespace cw5_api.Models;

public class SqlRepo : IRepo
{
    private readonly string _connectionString;
    public SqlRepo()
    {
        _connectionString = "Data Source=studentsDb.db";
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
        using var con = new SqliteConnection(_connectionString);
        using var cmd = con.CreateCommand();
        cmd.CommandText = "SELECT Id, FirstName, LastName, BirthDate FROM Students";
        con.Open();
        var students = new List<Student>();
        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            var student = new Student
            {
                Id = reader.GetInt32(0),
                FirstName = reader.GetString(1),
                LastName = reader.GetString(2),
                BirthDate = reader.GetDateTime(3)
            };
            students.Add(student);
        }
        con.Close();
        return students;
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
