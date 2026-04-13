using cw10_api.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<IRepoSqlite, RepoSqlite>();
// builder.Services.AddTransient<IRepoSqlite, RepoSqlite>();
// builder.Services.AddSingleton<IRepoSqlite, RepoSqlite>();
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/api", () => new { Message = "Hello from the API!", Date = DateTime.Now });
app.MapGet("/api/users", (IRepoSqlite repo) => repo.GetUsers());
app.MapGet("/api/users/{id}", (int id, IRepoSqlite repo) =>
{
    var user = repo.GetUser(id);
    if (user == null) return Results.NotFound();
    return Results.Ok(user);
});
   // repo.GetUser(id) is User user ? Results.Ok(user) : Results.NotFound());
app.Run();
