using System;
using MySql.Data.MySqlClient;

namespace pojazdy_sol.Models;

public class SqlRepo
{
    private string? _connectionString;
    public SqlRepo(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("mysql");
    }
    public List<Location> GetLocations()
    {
        List<Location> locations = new List<Location>();
        using var connection = new MySqlConnection(_connectionString);
        connection.Open();
        string query = "SELECT id, ulica FROM lokalizacje";
        using var command = connection.CreateCommand();
        command.CommandText = query;
        using var reader = command.ExecuteReader();
        while (reader.Read())
        {
            Location location = new Location
            {
                Id = reader.GetInt32("id"),
                Street = reader.GetString("ulica")
            };
            locations.Add(location);
        }
        return locations;
    }
    public List<Alert> GetAlerts()
    {
        List<Alert> alerts = new List<Alert>();
        using var connection = new MySqlConnection(_connectionString);

        connection.Open();
        string query = "SELECT lokalizacje.id,rejestracja, ulica, waga, dzien, czas,  lokalizacje_id FROM wagi JOIN lokalizacje ON wagi.lokalizacje_id = lokalizacje.id WHERE waga > 5";
        using var command = connection.CreateCommand();
        command.CommandText = query;
        using var reader = command.ExecuteReader();
        while (reader.Read())
        {
            Alert alert = new Alert
            {
                Id = reader.GetInt32("id"),
                LocationId = reader.GetInt32("lokalizacje_id"),
                Registration = reader.GetString("rejestracja"),
                Street = reader.GetString("ulica"),
                Weight = reader.GetInt32("waga"),
                Day = DateOnly.FromDateTime(reader.GetDateTime("dzien")),
                Time = TimeOnly.FromTimeSpan(reader.GetTimeSpan("czas"))
            };
            alerts.Add(alert);
        }

        return alerts;
    }
    public void AddAlert()
    {
            using var connection = new MySqlConnection(_connectionString);
            connection.Open();
            string query = "INSERT INTO wagi(lokalizacje_id, waga, rejestracja, dzien, czas) VALUES ('5', FLOOR(RAND()*10+1), 'DW12345', CURRENT_DATE, CURRENT_TIME)";
            using var command = connection.CreateCommand();
            command.CommandText = query;
            command.ExecuteNonQuery();
            Console.WriteLine("Alert added to database.");
    }
}
