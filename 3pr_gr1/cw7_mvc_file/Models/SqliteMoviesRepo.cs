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
        using var connection = new SqliteConnection(_connectionString);
        using var command = connection.CreateCommand();
        command.CommandText = @"DELETE FROM Movies WHERE id = @id";
        command.Parameters.AddWithValue("@id", id);
        connection.Open();
        command.ExecuteNonQuery();
        connection.Close();
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
        //obiekt connection do bazy danych, korzystamy z using, zeby po zakonczeniu uzywania polaczenia bylo ono zamkniete
        using var connection = new SqliteConnection(_connectionString);
        //tworzymy obiekt command, ktory pozwala nam wykonac zapytanie do bazy danych
        using var command = connection.CreateCommand();
        //zapytanie SQL, ktore chcemy wykonac
        command.CommandText = "SELECT id, title, director,year FROM Movies WHERE id = @id";
        command.Parameters.AddWithValue("@id", id);
        //otwieramy polaczenie z baza danych
        connection.Open();
        using var reader = command.ExecuteReader();
        if(!reader.HasRows) return null; //nie znaleziono filmu o podanym id
        Movie? movie = null;
        if (reader.Read())
        {
            movie = new Movie{
                Id = reader.GetInt32(0),
                Title = reader.GetString(1),
                Director = reader.GetString(2),
                Year = reader.GetInt32(3)
            };
        } 
        return movie;
    }

    public void Update(Movie movie)
    {
        using var connection = new SqliteConnection(_connectionString);
        using var command = connection.CreateCommand();
        command.CommandText = @"UPDATE Movies SET title = @title, director = @director, year = @year 
                        WHERE id = @id";
        command.Parameters.AddWithValue("@title", movie.Title);
        command.Parameters.AddWithValue("@director", movie.Director);
        command.Parameters.AddWithValue("@year", movie.Year);
        command.Parameters.AddWithValue("@id", movie.Id);
        connection.Open();
        command.ExecuteNonQuery();
        connection.Close();
    }
}
