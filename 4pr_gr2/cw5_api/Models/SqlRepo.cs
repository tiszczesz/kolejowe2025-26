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
        using var con = new SqliteConnection(_connectionString);
        using var cmd = con.CreateCommand();
        cmd.CommandText = "INSERT INTO Students (FirstName, LastName, BirthDate) "
                      + " VALUES (@firstName, @lastName, @birthDate)";
        cmd.Parameters.AddWithValue("@firstName", student.FirstName);
        cmd.Parameters.AddWithValue("@lastName", student.LastName);
        cmd.Parameters.AddWithValue("@birthDate", student.BirthDate);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
    }

    public void DeleteStudent(int id)
    {
        using var con = new SqliteConnection(_connectionString);
        using var cmd = con.CreateCommand();
        cmd.CommandText = "DELETE FROM Students WHERE Id = @id";
        cmd.Parameters.AddWithValue("@id", id);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
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
        using var con = new SqliteConnection(_connectionString);
        using var cmd = con.CreateCommand();
        cmd.CommandText = "SELECT Id, FirstName, LastName, BirthDate "
           + "FROM Students WHERE Id = @id";
        cmd.Parameters.AddWithValue("@id", id);
        con.Open();
        using var reader = cmd.ExecuteReader();
        if (reader.HasRows == false)
        {
            return null;
        }
        reader.Read();
        var student = new Student
        {
            Id = reader.GetInt32(0),
            FirstName = reader.GetString(1),
            LastName = reader.GetString(2),
            BirthDate = reader.GetDateTime(3)
        };
        con.Close();
        return student;
    }

    public void UpdateStudent(Student student)
    {
        using var con = new SqliteConnection(_connectionString);
        using var cmd = con.CreateCommand();
        cmd.CommandText = "UPDATE Students SET FirstName = @firstName, "
                      + " LastName = @lastName, BirthDate = @birthDate "
                      + " WHERE Id = @id";
        cmd.Parameters.AddWithValue("@firstName", student.FirstName);
        cmd.Parameters.AddWithValue("@lastName", student.LastName);
        cmd.Parameters.AddWithValue("@birthDate", student.BirthDate);
        cmd.Parameters.AddWithValue("@id", student.Id);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
    }
}
