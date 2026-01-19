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
    [Range(1888, 2100, ErrorMessage = "Rok produkcji musi być pomiędzy 1888 a 2100")]
    public int? Year { get; set; }
}
