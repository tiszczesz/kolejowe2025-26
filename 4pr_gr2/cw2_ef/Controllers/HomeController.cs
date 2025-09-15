using cw2_ef.Models;
using Microsoft.AspNetCore.Mvc;

namespace cw2_ef.Controllers
{
    public class HomeController : Controller
    {
        private readonly BooksContext _context;
        public HomeController(BooksContext context)
        {
            _context = context;
        }
        // GET: HomeController
        public ActionResult Index()
        {
            var books = _context.Books.ToList();
            return View(books);
        }
        public IActionResult AddNew()
        {
            var book = new Book
            {
                Title = "Nowa Książka",
                Author = "Nowy Autor",
                PublishedDate = DateTime.Now
            };
            _context.Books.Add(book);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Editors()
        {
            var editors = _context.Editors.ToList();
            return View(editors);
        }
        [HttpGet]
        public IActionResult AddEditor()
        {
            //wyswietlenie formularza
            return View();
        }
        [HttpPost]
        public IActionResult AddEditor(Editor editor)
        {
            if (!ModelState.IsValid)
            {
                return View(editor);
            }
            _context.Editors.Add(editor);
            _context.SaveChanges();
            return RedirectToAction(nameof(Editors));
        }


        public IActionResult DeleteEditor(int? id)
        {
            var toDelete = _context.Editors.FirstOrDefault(e => e.Id == id);
            if (toDelete != null)
            {

                _context.Editors.Remove(toDelete);


                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Editors));
        }
        [HttpGet]
        public IActionResult EditEditor(int? id)
        {
            var toEdit = _context.Editors.FirstOrDefault(e => e.Id == id);
            if (toEdit != null)
            {
                return View(toEdit);
            }
            return RedirectToAction(nameof(Editors));
        }
        [HttpPost]
        public IActionResult EditEditor(Editor editor)
        {
            if (ModelState.IsValid)
            {
                _context.Editors.Update(editor);
                _context.SaveChanges();
                return RedirectToAction(nameof(Editors));
            }
           return View(editor);
         }

    }
}
