using System;

namespace cw5_api.Models;

public interface ISqliteRepo
{
    void AddBook(Book book);
    Book? GetBook(int id);
    void UpdateBook(Book book);
    void DeleteBook(int id);
    List<Book> GetAllBooks();
}
