using cw5_api.Models;

var builder = WebApplication.CreateBuilder(args);
//dodaje do kontenera DI FakeRepo jako implementacje IRepo
builder.Services.AddScoped<IRepo, SqlRepo>();
//dodanie CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
});


var app = builder.Build();
//pobieram z kontenera DI implementacje IRepo
//var repo = app.Services.GetRequiredService<IRepo>();
app.UseCors("AllowAll");
app.MapGet("/", () => "Hello World!");
app.MapGet("/students", (IRepo repo) => repo.GetAll());
app.MapGet("/students/{id}", (IRepo repo, int id) =>
{
    var student = repo.GetStudent(id);
    if (student == null)
    {
        return Results.NotFound("Student not found");
    }
    return Results.Ok(student);
});
app.MapPost("/students", (IRepo repo, Student student) =>
    {
        repo.AddStudent(student);
        return Results.Ok("Student added");
    });

app.MapDelete("/students/{id}", (IRepo repo, int id) =>
{
    repo.DeleteStudent(id);
    return Results.Ok("Student deleted");
});

app.MapPut("/students/{id}", (IRepo repo,int? id,Student student) =>
{
    Student? studentToUpdate = repo.GetStudent(id ?? 0);
    if (studentToUpdate == null)
    {
        return Results.NotFound("Student not found");
    }
    student.Id = id ?? 0;
    repo.UpdateStudent(student);
    return Results.Ok("Student updated");
});

// app.MapGet("/students/{id}", (int id) =>
// {
//     var student = repo.GetStudent(id);
//     if (student == null)
//     {
//         return Results.NotFound("Student not found");
//     }
//     return Results.Ok(student);
// });

app.Run();
