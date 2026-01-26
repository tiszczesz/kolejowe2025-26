using System;
using Microsoft.Data.Sqlite;


namespace cw8_mvc_files.Models;

public class SqliteBooksRepo : IBooksRepo
{
    private readonly string? _connectionString;
    public SqliteBooksRepo(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("sqlite");
    }
    public void AddBook(Book book)
    {
        using var conn = new SqliteConnection(_connectionString);
        //obiekt zarzadzajacy komenda SQL
        using var cmd = conn.CreateCommand();
        cmd.CommandText = "INSERT INTO Books (title, author, yearPublished) "+
            "VALUES (@title, @author, @yearPublished)";
        cmd.Parameters.AddWithValue("@title", book.Title);
        cmd.Parameters.AddWithValue("@author", book.Author);
        cmd.Parameters.AddWithValue("@yearPublished", book.YearPublished);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
    }

    public void DeleteBook(int id)
    {
        throw new NotImplementedException();
    }

    public Book? GetBookById(int id)
    {
        using var conn = new SqliteConnection(_connectionString);
        //obiekt zarzadzajacy komenda SQL
        using var cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT id, title, author, yearPublished FROM Books "+
            $"WHERE id = {id}";
        conn.Open();
        //obiekt zarzadzajacy wynikiem zapytania
        var reader = cmd.ExecuteReader();
        if (!reader.HasRows)
        {
            return null; //brak ksiazki o podanym id
        }      
        var book = new Book
        {
            Id = reader.GetInt32(0),
            Title = reader.GetString(1),
            Author = reader.GetString(2),
            YearPublished = reader.GetInt32(3)
        };  
        reader.Close();
        return book;
    }

    public List<Book> GetBooks()
    {
        var books = new List<Book>();
        //obiekt zarzadzajacy polaczeniem conn
        using var conn = new SqliteConnection(_connectionString);
        //obiekt zarzadzajacy komenda SQL
        using var cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT id, title, author, yearPublished FROM Books";
        conn.Open();
        //obiekt zarzadzajacy wynikiem zapytania
        var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            var book = new Book
            {
                Id = reader.GetInt32(0),
                Title = reader.GetString(1),
                Author = reader.GetString(2),
                YearPublished = reader.GetInt32(3)
            };
            books.Add(book);
        }
        reader.Close();
        return books;
    }

    public void UpdateBook(Book book)
    {
        throw new NotImplementedException();
    }
}
