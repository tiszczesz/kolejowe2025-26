using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace cw2_ef.Models;

public class Editor
{
    public int Id { get; set; }

    [DisplayName("Nazwa wydawcy")]
    [Required(ErrorMessage = "Pole nazwa jest wymagane")]
    public string? Name { get; set; }

    [DisplayName("Adres wydawcy")]
    [Required(ErrorMessage = "Pole nazwa jest wymagane")]
    public string? Address { get; set; }
}
