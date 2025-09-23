using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace cw3_layout.Models;

public class Car
{
    public int Id { get; set; }

    [DisplayName("Marka samochodu")]
    [Required(ErrorMessage = "Pole jest wymagane")]
    public string? Brand { get; set; }

    [DisplayName("Model samochodu")]
    [Required(ErrorMessage = "Pole jest wymagane")]
    public string? Model { get; set; }

    [DisplayName("Rok produkcji")]
    [Required(ErrorMessage = "Pole jest wymagane")]
    public int? Year { get; set; }
}
