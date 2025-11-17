using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using cw5_web.Models;

namespace cw5_web.Pages
{
    public class MyFormModel : PageModel
    {
        public Person MyPerson { get; set; }
        public void OnGet()
        {
            //sprawdzenie czy w zapytaniu są dane z formularza
            if(Request.Query.ContainsKey("firstName") && Request.Query.ContainsKey("age"))
            {

                var firstName = Request.Query["firstName"];
                var lastName = Request.Query["lastName"];
                var age = Request.Query["age"];
                MyPerson = new Person()
                {
                    FirstName = firstName,
                    Age = int.Parse(age)
                };
               

                //przetwarzanie danych z formularza
            }
            //zareagowanie na żądanie GET z formularza
        }
    }
}
