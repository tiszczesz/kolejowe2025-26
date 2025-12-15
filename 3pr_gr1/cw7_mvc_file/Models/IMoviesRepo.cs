using System;

namespace cw7_mvc_file.Models;

public interface IMoviesRepo
{
    public List<Movie> GetAll();
    public void AddMovie(Movie movie);
    public Movie? GetById(int id);
    public void Delete(int id);
    public void Update(Movie movie);
}
