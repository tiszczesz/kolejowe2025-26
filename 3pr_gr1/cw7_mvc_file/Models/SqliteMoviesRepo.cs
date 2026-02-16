using System;
using Microsoft.Data.Sqlite;

namespace cw7_mvc_file.Models;

public class SqliteMoviesRepo : IMoviesRepo
{
    private readonly string? _connectionString;
    public SqliteMoviesRepo(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("sqlite");
    }
    public void AddMovie(Movie movie)
    {
        using var connection = new SqliteConnection(_connectionString);
        using var command = connection.CreateCommand();
        command.CommandText = @"INSERT INTO Movies (title, director, year) 
                        VALUES (@title, @director, @year)";
        command.Parameters.AddWithValue("@title", movie.Title);
        command.Parameters.AddWithValue("@director", movie.Director);
        command.Parameters.AddWithValue("@year", movie.Year);
        connection.Open();
        command.ExecuteNonQuery();
        connection.Close();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public List<Movie> GetAll()
    {
        //obiekt connection do bazy danych, korzystamy z using, zeby po zakonczeniu uzywania polaczenia bylo ono zamkniete
        using var connection = new SqliteConnection(_connectionString);
        //tworzymy obiekt command, ktory pozwala nam wykonac zapytanie do bazy danych
        using var command = connection.CreateCommand();
        //zapytanie SQL, ktore chcemy wykonac
        command.CommandText = "SELECT id, title, director,year FROM Movies";
        //otwieramy polaczenie z baza danych
        connection.Open();
        using var reader = command.ExecuteReader();
        var movies = new List<Movie>();
        while (reader.Read())
        {
            movies.Add(new Movie{
                Id = reader.GetInt32(0),
                Title = reader.GetString(1),
                Director = reader.GetString(2),
                Year = reader.GetInt32(3)
            });
        } 
        return movies;
    }

    public Movie? GetById(int id)
    {
        throw new NotImplementedException();
    }

    public void Update(Movie movie)
    {
        throw new NotImplementedException();
    }
}
