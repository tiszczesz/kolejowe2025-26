using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cw5_RazorPages.Pages
{
    public class SecondModel : PageModel
    {
        public List<string> Colors { get; set; }
        public SecondModel()
        {
            Colors = new List<string> { "Red", "Green", "Blue", "Yellow" };
        }
        public void OnGet()
        {
        }
    }
}
