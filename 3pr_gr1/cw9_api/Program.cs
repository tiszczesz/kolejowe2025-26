using cw9_api.Models;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
//builder.Services.AddTransient<IRepoSql, RepoSql>();
builder.Services.AddScoped<IRepoSql, RepoSql>();

//builder.Services.AddSingleton<IRepoSql, RepoSql>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/api/", () =>
     new { Name = "John Doe", Age = 30, Date = DateTime.Now });
app.MapGet("/api/students", (IRepoSql repo) => repo.GetStudents());
app.MapGet("/api/students/{id}", (int id, IRepoSql repo) =>
{
     var student = repo.GetStudent(id);
     if (student == null)
          return Results.NotFound();
     return Results.Ok(student);
});

app.MapPost("/api/students", (Student student, IRepoSql repo) =>
{
     repo.AddStudent(student);
     return Results.Ok();
});
app.MapDelete("/api/students/{id}", (int id, IRepoSql repo) =>
{
     repo.DeleteStudent(id);
     return Results.Ok();
});
app.MapPut("/api/students/{id}", (int id, Student student, IRepoSql repo) =>
{
     var studentToUpdate = repo.GetStudent(id);
     if (studentToUpdate == null)
          return Results.NotFound();
     student.Id = id;
     repo.UpdateStudent(student);
     return Results.Ok();
});
app.Run();
