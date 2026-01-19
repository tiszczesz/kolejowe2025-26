using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace cw8_mvc_files.Models;

public class Book
{
    public int Id { get; set; }
    
    [DisplayName("Tytuł")]
    [Required(ErrorMessage = "Tytuł jest wymagany")]
    public string Title { get; set; }
    
    [DisplayName("Autor")]
    [Required(ErrorMessage = "Autor jest wymagany")]
    public string Author { get; set; }
    
    [DisplayName("Rok wydania")]
    [Required(ErrorMessage = "Rok wydania jest wymagany")]
    [Range(1450, 2100, ErrorMessage = "Rok wydania musi być między 1450 a 2100")]
    public int? YearPublished { get; set; }
}
