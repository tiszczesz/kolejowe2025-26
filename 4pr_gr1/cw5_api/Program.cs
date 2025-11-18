using cw5_api.Models;

var builder = WebApplication.CreateBuilder(args);
//wstrzykniecie do kontenera obsługi bazy danych
builder.Services.AddScoped<ISqliteRepo,SqliteRepo>();


var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/books", (ISqliteRepo repo) =>
{
    return repo.GetAllBooks();
});
app.MapGet("/books/{id}", (ISqliteRepo repo, int id) =>
{
    var book = repo.GetBook(id);
    if (book == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(book);
});
app.MapPost("/books", (ISqliteRepo repo, Book book) =>
{
    repo.AddBook(book);
    return Results.Created($"/books/{book.Id}", book);
});
app.MapDelete("/books/{id}", (ISqliteRepo repo, int id) =>
{
    //sprawdzenie czy książka o podanym id istnieje
    var book = repo.GetBook(id);
    if (book == null)
    {
        return Results.NotFound();
    }
    repo.DeleteBook(id);
    return Results.NoContent();
});
app.MapPut("/books/{id}", (ISqliteRepo repo, int id, Book updatedBook) =>
{
    var book = repo.GetBook(id);
    if (book == null)
    {
        return Results.NotFound();
    }
    //aktualizacja danych książki
    book.Title = updatedBook.Title;
    book.Author = updatedBook.Author;
    book.PublishedYear = updatedBook.PublishedYear;
    repo.UpdateBook(book);
    return Results.NoContent();
});

app.Run();
