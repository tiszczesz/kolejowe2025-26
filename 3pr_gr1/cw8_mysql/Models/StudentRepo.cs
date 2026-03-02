using System;
using MySql.Data.MySqlClient;

namespace cw8_mysql.Models;

public class StudentRepo
{
    private string? _connectionString;
    public StudentRepo(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("mysql");
    }
    public List<Student> GetStudents()
    {
        var students = new List<Student>();
        var conn = new MySqlConnection(_connectionString);
        var cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT id, firstname, lastname, date_of FROM students";
        conn.Open();
        var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            students.Add(new Student
            {
                Id = reader.GetInt32("id"),
                FirstName = reader.GetString("firstname"),
                LastName = reader.GetString("lastname"),
                DateOf = DateOnly.FromDateTime(reader.GetDateTime("date_of"))
            });
        }
        return students;
    }

}
