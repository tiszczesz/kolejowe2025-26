using System;

namespace cw4_class.Models;

public class BooksFileRepo
{
    public List<Book> Books { get; set; }
    private Book? ParseLine(string line)
    {
        var parts = line.Split(';');
        if (parts.Length != 5)
        {
            return null;
        }
        return new Book
        {
            Id = int.Parse(parts[0]),
            Title = parts[1],
            Author = parts[2],
            Year = int.Parse(parts[3]),
            IsDigital = bool.Parse(parts[4])
        };
    }
}
