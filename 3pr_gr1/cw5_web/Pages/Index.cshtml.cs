using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cw5_web.Pages
{
    public class IndexModel : PageModel
    {
        public DateTime ActualDate { get; set; }
        public void OnGet()
        {
            ActualDate = DateTime.Now;
        }
    }
}
