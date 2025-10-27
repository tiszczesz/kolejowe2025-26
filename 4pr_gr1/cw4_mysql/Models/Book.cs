using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace cw4_mysql.Models;

public class Book
{
    public int Id { get; set; }

    [DisplayName("Tytuł książki")]
    [Required(ErrorMessage = "Pole Tytuł książki jest wymagane")]
    public string Title { get; set; }
    
    [DisplayName("Autor")]
    [Required(ErrorMessage = "Pole Autor jest wymagane")]
    public string Author { get; set; }

    [DisplayName("Cena")]
    [Required(ErrorMessage = "Pole Cena jest wymagane")]
    public decimal? Price { get; set; }

    [DisplayName("Data wydania")]
    [Required(ErrorMessage = "Pole Data wydania jest wymagane")]
    public DateTime RealizeDate { get; set; }
}
