using cw5_web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cw5_web.Pages
{
    public class MyPostFormModel : PageModel
    {
        public Person MyPerson { get; set; }
        public void OnGet()
        {
        }
        public void OnPost()
        {
            //if(isset($_POST['firstname']))
            if (Request.Form.ContainsKey("firstname"))
            {
                MyPerson = new Person()
                {
                    FirstName = Request.Form["firstname"],
                    Age = int.Parse(Request.Form["age"])
                };
            }
        }
    }
}
