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

app.Run();
