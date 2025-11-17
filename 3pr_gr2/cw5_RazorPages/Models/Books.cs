using System;

namespace cw5_RazorPages.Models;

public class Books
{
    public static List<Book> GetSampleBooks()
    {
        return new List<Book>
        {
            new Book { Id = 1, Title = "1984", Author = "George Orwell", PublishedDate = new DateTime(1949, 6, 8) },
            new Book { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", PublishedDate = new DateTime(1960, 7, 11) },
            new Book { Id = 3, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", PublishedDate = new DateTime(1925, 4, 10) }
        };
    }
}

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public DateTime PublishedDate { get; set; }
}
