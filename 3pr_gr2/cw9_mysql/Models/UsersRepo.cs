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
        return users;
    }

}
