using System.IO;

namespace cw8_mvc_files.Models;

public class FileBooksRepo : IBooksRepo
{
    private readonly string filePath = "books.txt";
    public void AddBook(Book book)
    {
        book.Id = GetNextId();
        var books = GetBooks();
        books.Add(book);
        SaveBooks(books);
    }

    private void SaveBooks(List<Book> books)
    {
        var lines = new List<string>();
        foreach(var book in books)
        {
            lines.Add($"{book.Id}|{book.Title}|{book.Author}|{book.YearPublished}");
        }
        File.WriteAllLines(filePath, lines);
    }

    public Book? GetBookById(int id)
    {
        throw new NotImplementedException();
    }

    public List<Book> GetBooks()
    {
        var books = new List<Book>();
        var lines = File.ReadAllLines(filePath);
        foreach (var line in lines)
        {
            var parts = line.Split('|');
            if (parts.Length == 4)
            {
                books.Add(
                    new Book
                    {
                        Id = int.Parse(parts[0].Trim()),
                        Title = parts[1].Trim(),
                        Author = parts[2].Trim(),
                        YearPublished = int.Parse(parts[3].Trim())
                    }
                );
            }
        }
        return books;
    }

    public void UpdateBook(Book book)
    {
        throw new NotImplementedException();
    }
    private int GetNextId()
    {
        var books = GetBooks();
        if (books.Count == 0)
            return 1;
        return books.Max(b => b.Id) + 1;
    }
}
