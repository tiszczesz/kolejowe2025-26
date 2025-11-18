using System;
using Microsoft.Data.Sqlite;

namespace cw5_api.Models;

public class SqliteRepo : ISqliteRepo
{
    private readonly string? _connectionString;
    public SqliteRepo(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("Sqlite");
    }
    public void AddBook(Book book)
    {
        using SqliteConnection conn = new SqliteConnection(_connectionString);
        using SqliteCommand cmd = conn.CreateCommand();
        cmd.CommandText = "INSERT INTO Books (title, author, published_year) "
                   + "VALUES (@title, @author, @published_year);";
        cmd.Parameters.AddWithValue("@title", book.Title);
        cmd.Parameters.AddWithValue("@author", book.Author);
        cmd.Parameters.AddWithValue("@published_year", book.PublishedYear);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
    }

    public void DeleteBook(int id)
    {
        using SqliteConnection conn = new SqliteConnection(_connectionString);
        using SqliteCommand cmd = conn.CreateCommand();
        cmd.CommandText = "DELETE FROM Books WHERE id = @id";
        cmd.Parameters.AddWithValue("@id", id);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
    }

    public List<Book> GetAllBooks()
    {
        using SqliteConnection conn = new SqliteConnection(_connectionString);
        using SqliteCommand cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT id, title, author, published_year FROM Books";
        conn.Open();
        using SqliteDataReader reader = cmd.ExecuteReader();
        List<Book> books = new List<Book>();
        while (reader.Read())
        {
            Book book = new Book();
            book.Id = reader.GetInt32(0);
            book.Title = reader.GetString(1);
            book.Author = reader.GetString(2);
            book.PublishedYear = reader.GetInt32(3);
            books.Add(book);
        }
        return books;
    }

    public Book? GetBook(int id)
    {
        using SqliteConnection conn = new SqliteConnection(_connectionString);
        using SqliteCommand cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT id, title, author, published_year FROM Books WHERE id = @id";
        cmd.Parameters.AddWithValue("@id", id);
        conn.Open();
        using SqliteDataReader reader = cmd.ExecuteReader();
        if (!reader.HasRows)
        {
            return null;
        }
        reader.Read();
        Book book = new Book();
        book.Id = reader.GetInt32(0);
        book.Title = reader.GetString(1);
        book.Author = reader.GetString(2);
        book.PublishedYear = reader.GetInt32(3);
        return book;
    }

    public void UpdateBook(Book book)
    {
        throw new NotImplementedException();
    }
}
