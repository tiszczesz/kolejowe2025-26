using cw5_web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cw5_web.Pages
{
    public class IndexModel : PageModel
    {
        public List<Contact> Contacts { get; set; }
        public IndexModel()
        {
            var lines = System.IO.File.ReadAllLines("dane.csv");
            Contacts = new List<Contact>();
            foreach (var line in lines)
            {
                var data = line.Split(';');
                if (data.Length == 4)
                {
                    Contacts.Add(
                        new Contact
                        {
                            FirstName = data[0],
                            LastName = data[1],
                            Age = int.Parse(data[2]),
                            IsFamily = bool.Parse(data[3])
                        }
                    );
                }
            }
            
        }
        public DateTime ActualDate { get; set; }
        public void OnGet()
        {
            ActualDate = DateTime.Now;
        }
    }
}
