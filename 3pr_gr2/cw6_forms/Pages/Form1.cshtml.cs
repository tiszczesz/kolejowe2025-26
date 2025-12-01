using cw6_forms.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cw6_forms.Pages
{
    public class Form1Model : PageModel
    {
        public Person  MyPerson{get;set;} = new Person();
        public void OnGet()
        {
            if(Request.Query.ContainsKey("firstname"))
            {
                ViewData["Message"] = "Dane zostały przesłane metodą GET";
                MyPerson.FirstName = Request.Query["firstname"];
                MyPerson.LastName = Request.Query["lastname"];
                MyPerson.Age = Convert.ToInt32(Request.Query["age"]);                
            }
            
        }
    }

   
}
