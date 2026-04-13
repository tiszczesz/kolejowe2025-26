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
        using var connection = new SqliteConnection(_connectionString);
        using var command = connection.CreateCommand();
        command.CommandText = @"INSERT INTO Students (Firstname, Lastname, AVG_Grade, Departament_id) 
                                    VALUES (@firstname, @lastname, @avg_grade, @departament_id)";
        command.Parameters.AddWithValue("@firstname", student.Firstname);
        command.Parameters.AddWithValue("@lastname", student.Lastname);
        command.Parameters.AddWithValue("@avg_grade", student.AVG_Grade);
        command.Parameters.AddWithValue("@departament_id", student.Departament_id);
        connection.Open();
        command.ExecuteNonQuery();
        connection.Close();        
    }

    public void DeleteStudent(int id)
    {
        using var connection = new SqliteConnection(_connectionString);
        using var command = connection.CreateCommand();
        command.CommandText = @"DELETE FROM Students WHERE Id = @id";
        command.Parameters.AddWithValue("@id", id);
        connection.Open();
        command.ExecuteNonQuery();
        connection.Close(); 
    }

    public List<Departament> GetDepartaments()
    {
        throw new NotImplementedException();
    }

    public Student? GetStudent(int id)
    {
        using var connection = new SqliteConnection(_connectionString);
        using var command = connection.CreateCommand();
        command.CommandText = "SELECT * FROM Students WHERE Id = @id";
        command.Parameters.AddWithValue("@id", id);
        connection.Open();
        var reader = command.ExecuteReader();
        if (!reader.HasRows)
        {
            connection.Close();
            return null;
        }
        reader.Read();
        var student = new Student
        {
            Id = reader.GetInt32(0),
            Firstname = reader.GetString(1),
            Lastname = reader.GetString(2),
            AVG_Grade = reader.GetDouble(3),
            Departament_id = reader.GetInt32(4)
        };
        connection.Close();
        return student;
    }

    public List<Student> GetStudents()
    {
        using var connection = new SqliteConnection(_connectionString);
        using var command = connection.CreateCommand();
        command.CommandText = "SELECT * FROM Students";
        connection.Open();
        var reader = command.ExecuteReader();
        var students = new List<Student>();
        while (reader.Read())
        {
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
        using var connection = new SqliteConnection(_connectionString);
        using var command = connection.CreateCommand();
        command.CommandText = @"UPDATE Students SET Firstname = @firstname, Lastname = @lastname, 
                                    AVG_Grade = @avg_grade, Departament_id = @departament_id
                                    WHERE Id = @id";
        command.Parameters.AddWithValue("@id", student.Id);
        command.Parameters.AddWithValue("@firstname", student.Firstname);
        command.Parameters.AddWithValue("@lastname", student.Lastname);
        command.Parameters.AddWithValue("@avg_grade", student.AVG_Grade);
        command.Parameters.AddWithValue("@departament_id", student.Departament_id);
        connection.Open();
        command.ExecuteNonQuery();
        connection.Close();
    }
}
