using System;
using Microsoft.Data.Sqlite;

namespace cw9_api.Models;

public class RepoSql : IRepoSql
{
    private readonly string _connectionString;
    public RepoSql(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("sqlite") 
                ?? "Data Source=appdb.db";
    }
    public void AddDepartament(Departament departament)
    {
        throw new NotImplementedException();
    }

    public void AddStudent(Student student)
    {
        throw new NotImplementedException();
    }

    public void DeleteStudent(int id)
    {
        throw new NotImplementedException();
    }

    public List<Departament> GetDepartaments()
    {
        throw new NotImplementedException();
    }

    public Student? GetStudent(int id)
    {
        throw new NotImplementedException();
    }

    public List<Student> GetStudents()
    {
        using var connection = new SqliteConnection(_connectionString);
        using var command = connection.CreateCommand();
        command.CommandText = "SELECT * FROM Student";
        connection.Open();
        var reader = command.ExecuteReader();   
        var students = new List<Student>();
        while (reader.Read())        {
            var student = new Student
            {
                Id = reader.GetInt32(0),
                Firstname = reader.GetString(1),
                Lastname = reader.GetString(2),
                AVG_Grade = reader.GetDouble(3),
                Departament_id = reader.GetInt32(4)
            };
            students.Add(student);
        }
        connection.Close();
        return students;
    }

    public void UpdateStudent(Student student)
    {
        throw new NotImplementedException();
    }
}
