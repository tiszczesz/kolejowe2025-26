using System;
using MySql.Data.MySqlClient;

namespace ark_zawody.Models;

public class SqlRepoZawody
{
    private readonly string? _connectionString;
    public SqlRepoZawody(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("mysql");
    }
    public List<Lowiska> GetLowiska()
    {
        var lowiskaList = new List<Lowiska>();
        using var connection = new MySqlConnection(_connectionString);
        using MySqlCommand command = connection.CreateCommand();
        command.CommandText = "SELECT * FROM lowisko";
        connection.Open();
        using var reader = command.ExecuteReader();

        while (reader.Read())
        {
            var lowisko = new Lowiska
            {
                Id = reader.GetInt32("Id"),
                Ryby_id = reader.GetInt32("Ryby_id"),
                Akwen = reader.GetString("Akwen"),
                Wojewodztwo = reader.GetString("Wojewodztwo"),
                Rodzaj = reader.GetInt32("Rodzaj")
            };
            lowiskaList.Add(lowisko);
        }
        return lowiskaList;
    }

}
