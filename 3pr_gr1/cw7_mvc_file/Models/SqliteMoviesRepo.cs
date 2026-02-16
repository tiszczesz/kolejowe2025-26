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
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public List<Movie> GetAll()
    {
        using var connection = new SqliteConnection(_connectionString);
        var movies = new List<Movie>();


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
