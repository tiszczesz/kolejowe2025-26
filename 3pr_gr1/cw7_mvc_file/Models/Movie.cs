using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace cw7_mvc_file.Models;

public class Movie
{
    public int Id { get; set; }
    
    [DisplayName("Tytuł")]
    [Required(ErrorMessage = "Pole Tytuł jest wymagane")]
    public string Title { get; set; }
    
     [DisplayName("Reżyser")]
    [Required(ErrorMessage = "Pole Reżyser jest wymagane")]
    public string Director { get; set; }
    
    [DisplayName("Rok produkcji")]
    [Required(ErrorMessage = "Pole Rok produkcji jest wymagane")]
    public int? Year { get; set; }
}
