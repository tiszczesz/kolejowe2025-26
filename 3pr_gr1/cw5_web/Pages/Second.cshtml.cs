using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cw5_web.Pages
{
    public class SecondModel : PageModel
    {
        public string[] Colors { get; set; }
        public SecondModel()
        {
            Colors = new[] { "white","red", "green", "blue", "yellow" };
        }
        public void OnGet()
        {
            Console.WriteLine("OnGet - Second.cshtml.cs");
        }
    }
}
