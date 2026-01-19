using System;
using System.Text.Json;

namespace cw7_mvc_file.Models;

public class FileMoviesRepo : IMoviesRepo
{
    private readonly string _filePath = "movies.json";
    private List<Movie> LoadFromFile() //deserializacja
    {
        string json = File.ReadAllText(_filePath);
        return JsonSerializer.Deserialize<List<Movie>>(json) 
               ?? new List<Movie>();
    }
    private void SaveToFile(List<Movie> movies)//serializacja
    {
        string json = JsonSerializer.Serialize(movies);
        File.WriteAllText(_filePath, json);
    }
    private int GetNextId(){ //autoinkrementacja Id
        var movies = LoadFromFile();
        if(movies.Count == 0) return 1;
        return movies.Max(m => m.Id) + 1;
    }
    public void AddMovie(Movie movie)
    {
        movie.Id = GetNextId();
        var movies = LoadFromFile();
        movies.Add(movie);
        SaveToFile(movies);
    }

    public void Delete(int id)
    {
        var movies = LoadFromFile();
        var movieToDelete = movies.Find(m => m.Id == id);
        if (movieToDelete != null)
        {
            //w liscie znalazlismy film do usuniecia
            movies.Remove(movieToDelete);
            //zapisz zaktualizowana liste do pliku
            SaveToFile(movies);
        }
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
