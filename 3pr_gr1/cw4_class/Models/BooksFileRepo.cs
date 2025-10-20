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
    public List<Book> LoadBooksFromFile(string filePath)
    {
        Books = new List<Book>();
        var lines = File.ReadAllLines(filePath);
        foreach (var line in lines)
        {
            var book = ParseLine(line);
            if (book != null)
            {
                Books.Add(book);
            }
        }
        return Books;
    }
    public BooksFileRepo(string filePath)
    {
        Books = LoadBooksFromFile(filePath);
    }
}
