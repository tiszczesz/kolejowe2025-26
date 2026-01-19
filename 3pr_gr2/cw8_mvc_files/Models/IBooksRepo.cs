using System;

namespace cw8_mvc_files.Models;

public interface IBooksRepo
{
    public List<Book> GetBooks();
    public void AddBook(Book book);
    public Book? GetBookById(int id);
    public void UpdateBook(Book book);
    public void DeleteBook(int id);
}
