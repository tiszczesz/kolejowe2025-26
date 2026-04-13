using cw10_api.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<IRepoSqlite, RepoSqlite>();
// builder.Services.AddTransient<IRepoSqlite, RepoSqlite>();
// builder.Services.AddSingleton<IRepoSqlite, RepoSqlite>();

//obsługa CORS pełna dowolność, do testów z JS w przeglądarce
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});
var app = builder.Build();
app.UseCors();

app.MapGet("/", () => "Hello World!");
app.MapGet("/api", () => new { Message = "Hello from the API!", Date = DateTime.Now });
app.MapGet("/api/users", (IRepoSqlite repo) => repo.GetUsers());
app.MapGet("/api/users/{id}", (int id, IRepoSqlite repo) =>
{ 
    // repo.GetUser(id) is User user ? Results.Ok(user) : Results.NotFound());
    var user = repo.GetUser(id);
    if (user == null) return Results.NotFound();
    return Results.Ok(user);
});

app.MapPost("/api/users", (User user, IRepoSqlite repo) => repo.AddUser(user));

app.MapDelete("/api/users/{id}", (int id, IRepoSqlite repo) => repo.DeleteUser(id));  

app.MapPut("/api/users/{id}", (int id, User user, IRepoSqlite repo) => 
{
    var existingUser = repo.GetUser(id);
    if (existingUser == null) return Results.NotFound();
    user.Id = id;
    repo.UpdateUser(user);
    return Results.Ok(user);
});
app.Run();
