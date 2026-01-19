using cw7_mvc_file.Models;
using Microsoft.AspNetCore.Mvc;

namespace cw7_mvc_file.Controllers
{
    public class MoviesLibController : Controller
    {
        private IMoviesRepo _moviesRepo;
        public MoviesLibController(IMoviesRepo moviesRepo)
        {
            _moviesRepo = moviesRepo;
        }
        // GET: MoviesLibController
        public ActionResult List()
        {
            var movies = _moviesRepo.GetAll();
            return View(movies);
        }

        [HttpGet]
        public IActionResult AddMovie()
        {
            // Display the form to add a new movie
            return View();
        }
        [HttpPost]
        public IActionResult AddMovie(Movie movie)
        {
            // Process the form submission
            if (!ModelState.IsValid)
            {
                // If the model state is invalid, redisplay the form with validation errors
                return View();
            }
            _moviesRepo.AddMovie(movie);
            return RedirectToAction("List");
        }
        public IActionResult DeleteMovie(int id)
        {
            _moviesRepo.Delete(id);
            return RedirectToAction("List");
        }
        [HttpGet]
        public IActionResult UpdateMovie(int id)
        {
            var movie = _moviesRepo.GetById(id);
            if (movie == null)
            {
                return RedirectToAction("List");
            }
            return View(movie);
        }
        [HttpPost]
        public IActionResult UpdateMovie(Movie movie)
        {            
            if (!ModelState.IsValid)
            {
                // If the model state is invalid, redisplay the form with validation errors
                return View();
            }
            //ZAPISUJEMY ZMIANY
            //wracamy do listy filmów
            _moviesRepo.Update(movie);
            return RedirectToAction("List");
        }
    }
}
