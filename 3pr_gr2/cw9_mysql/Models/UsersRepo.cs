using System;
using MySql.Data.MySqlClient;
namespace cw9_mysql.Models;

public class UsersRepo
{
    private readonly string? _connectionString;
    public UsersRepo(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("mysql");
    }
    public List<User> GetUsers()
    {
        var users = new List<User>();
        using var conn = new MySqlConnection(_connectionString);
        using var cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT id,firstname,lastname,creating_date FROM users";
        conn.Open();
        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            var user = new User
            {
                Id = reader.GetInt32("id"),
                FirstName = reader.GetString("firstname"),
                LastName = reader.GetString("lastname"),
                CreatingDate = DateOnly.FromDateTime(reader.GetDateTime("creating_date"))
            };
            users.Add(user);
        }
        conn.Close();
        return users;
    }
    public void AddUser(User user)
    {
        using var conn = new MySqlConnection(_connectionString);
        using var cmd = conn.CreateCommand();
        cmd.CommandText = @"INSERT INTO users (firstname, lastname, creating_date)
                    VALUES (@firstname, @lastname, @creating_date)";
        cmd.Parameters.AddWithValue("@firstname", user.FirstName);
        cmd.Parameters.AddWithValue("@lastname", user.LastName);
        cmd.Parameters.AddWithValue("@creating_date",
         user.CreatingDate.ToDateTime(new TimeOnly(0, 0)));
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
    }
    public void DeleteUser(int id)
    {
        using var conn = new MySqlConnection(_connectionString);
        using var cmd = conn.CreateCommand();
        cmd.CommandText = "DELETE FROM users WHERE id = @id";
        cmd.Parameters.AddWithValue("@id", id);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
    }

}
