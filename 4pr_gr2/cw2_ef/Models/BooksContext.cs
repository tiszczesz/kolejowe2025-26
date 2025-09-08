using System;
using Microsoft.EntityFrameworkCore;

namespace cw2_ef.Models;

public class BooksContext : DbContext
{
    public BooksContext(DbContextOptions<BooksContext> options)
        : base(options)
    { }
    public DbSet<Book> Books { get; set; }
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
    }
}
