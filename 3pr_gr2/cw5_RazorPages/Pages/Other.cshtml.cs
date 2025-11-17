using cw5_RazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cw5_RazorPages.Pages
{
    public class OtherModel : PageModel
    {
        public List<Book> MyBooks { get; set; }
        public void OnGet()
        {
            MyBooks = Books.GetSampleBooks();
        }
    }
}
