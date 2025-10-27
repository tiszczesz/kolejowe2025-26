using System;
using MySql.Data.MySqlClient;

namespace cw4_mysql.Models;

public class BookRepo
{
    private string? _connectionString;
    public BookRepo(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("mysql");
    }
    public List<Book> GetBooks()
    {
        List<Book> books = new();
        using var conn = new MySqlConnection(_connectionString);
        using var cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT id, title, author, price, realizeDate FROM books";
        conn.Open();
        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            var book = new Book
            {
                Id = reader.GetInt32("id"),
                Title = reader.GetString("title"),
                Author = reader.GetString("author"),
                Price = reader.GetDecimal("price"),
                RealizeDate = reader.GetDateTime("realizeDate")
            };
            books.Add(book);
        }
        conn.Close();
        return books;
    }
}
