using System;
using Microsoft.EntityFrameworkCore;

namespace cw2_ef.Models;

public class BooksContext : DbContext
{
    public BooksContext(DbContextOptions<BooksContext> options)
        : base(options)
    { }
    public DbSet<Book> Books { get; set; }
    public DbSet<Editor> Editors { get; set; }
    //dodanie startowych danych
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        //dodanie startowych danych
        modelBuilder.Entity<Book>().HasData(
            new Book
            {
                Id = 1,
                Title = "Wiedźmin: Ostatnie życzenie",
                Author = "Andrzej Sapkowski",
                PublishedDate = new DateTime(1993, 1, 1)
            },
            new Book
            {
                Id = 2,
                Title = "Harry Potter i Kamień Filozoficzny",
                Author = "J.K. Rowling",
                PublishedDate = new DateTime(1997, 6, 26)
            },
            new Book
            {
                Id = 3,
                Title = "Hobbit, czyli tam i z powrotem",
                Author = "J.R.R. Tolkien",
                PublishedDate = new DateTime(1937, 9, 21)
            }
        );
        modelBuilder.Entity<Editor>().HasData(
            new Editor
            {
                Id = 1,
                Name = "Appress",
                Address = "ul. Wookkk, Kraków 31-161"
            },
            new Editor
            {
                Id = 2,
                Name = "Trrrrr",
                Address = "ul. Wookkk, Kraków 31-161"
            },
            new Editor
            {
                Id = 3,
                Name = "Rainbow",
                Address = "ul. Wookkk, Kraków 31-161"
            },
            new Editor
            {
                Id = 4,
                Name = "Feryk",
                Address = "ul. Zygmunta, Kraków 31-161"
            }
        );
    }
}
