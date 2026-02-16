using System;
using System.Data;
using Microsoft.Data.Sqlite;

namespace cw8_mvc_files.Models;

public class SqliteFishRepo : IFishRepo
{
    private string? _connectionString;
    public SqliteFishRepo(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("sqlite2");
    }
    public void AddFish(Fish fish)
    {
        throw new NotImplementedException();
    }

    public void DeleteFish(int id)
    {
        throw new NotImplementedException();
    }

    public Fish? GetFishById(int id)
    {
        throw new NotImplementedException();
    }

    public List<Fish> GetFishes()
    {
        using var conn = new SqliteConnection(_connectionString);
        conn.Open();
        var cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT * FROM Fishes";
        var reader = cmd.ExecuteReader();
        var fishes = new List<Fish>();
        while (reader.Read())
        {
            fishes.Add(new Fish
            {
                Id = reader.GetInt32("Id"),
                Name = reader.GetString("Name"),
                Species = reader.GetString("Species"),
                Age = reader.GetInt32("Age")
            });
        }
        return fishes;
    }

    public void UpdateFish(Fish fish)
    {
        throw new NotImplementedException();
    }
}
