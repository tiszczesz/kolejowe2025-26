using System;
using Microsoft.Data.Sqlite;

namespace cw10_api.Models;

public class RepoSqlite : IRepoSqlite
{
    private readonly string _connectionString;
    public RepoSqlite(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("sqlite") ?? "Data Source=myapp.db";
    }
    public void AddRole(Role role)
    {
        throw new NotImplementedException();
    }

    public void AddUser(User user)
    {
        using var conn = new SqliteConnection(_connectionString);
        using var cmd = conn.CreateCommand();
        cmd.CommandText = "INSERT INTO Users (name, email, role_id) VALUES (@name, @email, @role_id)";
        cmd.Parameters.AddWithValue("@name", user.Name);
        cmd.Parameters.AddWithValue("@email", user.Email);
        cmd.Parameters.AddWithValue("@role_id", user.RoleId);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();

    }

    public void DeleteUser(int id)
    {
        throw new NotImplementedException();
    }

    public Role? GetRole(int id)
    {
        throw new NotImplementedException();
    }

    public IList<Role> GetRoles()
    {
        throw new NotImplementedException();
    }

    public User? GetUser(int id)
    {
        using var conn = new SqliteConnection(_connectionString);
        using var cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT id, name, email, role_id  FROM Users WHERE id = @id";
        cmd.Parameters.AddWithValue("@id", id);
        conn.Open();
        using var reader = cmd.ExecuteReader();
        if (!reader.HasRows) return null;
        reader.Read();
        var user = new User
        {
            Id = reader.GetInt32(0),
            Name = reader.GetString(1),
            Email = reader.GetString(2),
            RoleId = reader.GetInt32(3)
        };
        return user;
    }

    public IList<User> GetUsers()
    {
        using var conn = new SqliteConnection(_connectionString);
        using var cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT id, name, email, role_id  FROM Users";
        conn.Open();
        using var reader = cmd.ExecuteReader();
        var users = new List<User>();
        while (reader.Read())
        {
            var user = new User
            {
                Id = reader.GetInt32(0),
                Name = reader.GetString(1),
                Email = reader.GetString(2),
                RoleId = reader.GetInt32(3)
            };
            users.Add(user);
        }
        conn.Close();
        return users;
    }

    public void UpdateUser(User user)
    {
        throw new NotImplementedException();
    }
}
