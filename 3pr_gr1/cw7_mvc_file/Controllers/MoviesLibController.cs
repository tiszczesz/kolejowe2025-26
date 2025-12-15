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
            return View();
        }

    }
}
