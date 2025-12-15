using System;
using System.Text.Json;

namespace cw7_mvc_file.Models;

public class FileMoviesRepo : IMoviesRepo
{
    private readonly string _filePath = "movies.json";
    private List<Movie> LoadFromFile()
    {
        string json = File.ReadAllText(_filePath);
        return JsonSerializer.Deserialize<List<Movie>>(json) 
               ?? new List<Movie>();
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
        return LoadFromFile();
    }

    public Movie? GetById(int id)
    {
        return LoadFromFile().FirstOrDefault(m => m.Id == id);
    }

    public void Update(Movie movie)
    {
        throw new NotImplementedException();
    }
}
