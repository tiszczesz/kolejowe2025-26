using System;

namespace cw5_web.Models;

public class Books
{
    public static List<Book> GetBooks()
    {
        return new List<Book>
        {
            new Book { Title = "1984", Author = "George Orwell", Year = 1949 },
            new Book { Title = "To Kill a Mockingbird", Author = "Harper Lee", Year = 1960 },
            new Book { Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Year = 1925 }
        };
    }
}

public class Book
{
    public string? Title { get; set; }
    public string? Author { get; set; }
    public int Year { get; set; }
}
