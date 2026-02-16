using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace cw8_mvc_files.Models;

public class Fish
{
public int Id { get; set; }

    [DisplayName("Nazwa")]
    [Required(ErrorMessage = "Nazwa jest wymagana")]
    public string Name { get; set; }

    [DisplayName("Gatunek")]
    [Required(ErrorMessage = "Gatunek jest wymagany")]
    public string Species { get; set; }

    [DisplayName("Wiek")]
    [Required(ErrorMessage = "Wiek jest wymagany")]
    [Range(0, 200, ErrorMessage = "Wiek musi byc miedzy 0 a 200")]
    public int? Age { get; set; }
}
