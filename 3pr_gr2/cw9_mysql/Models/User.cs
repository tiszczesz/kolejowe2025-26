using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace cw9_mysql.Models;

public class User
{
    public int Id { get; set; }
    
    [DisplayName("Imię")]
    [Required(ErrorMessage = "Pole imię jest wymagane.")]
    [StringLength(50, ErrorMessage = "Imię nie może być dłuższe niż 50 znaków.")]
    public string FirstName { get; set; }
    
    [DisplayName("Nazwisko")]
    [Required(ErrorMessage = "Pole nazwisko jest wymagane.")]
    [StringLength(50, ErrorMessage = "Nazwisko nie może być dłuższe niż 50 znaków.")]
    public string LastName { get; set; }
    public DateOnly CreatingDate { get; set; }
}
