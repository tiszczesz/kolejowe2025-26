using cw5_api.Models;

var builder = WebApplication.CreateBuilder(args);
//dodaje do kontenera DI FakeRepo jako implementacje IRepo
builder.Services.AddScoped<IRepo, SqlRepo>();
var app = builder.Build();
//pobieram z kontenera DI implementacje IRepo
var repo = app.Services.GetRequiredService<IRepo>();

app.MapGet("/", () => "Hello World!");
app.MapGet("/students", () => repo.GetAll());
app.MapGet("/students/{id}", (int id) =>
{
    var student = repo.GetStudent(id);
    if (student == null)
    {
        return Results.NotFound("Student not found");
    }
    return Results.Ok(student);
});

app.Run();
