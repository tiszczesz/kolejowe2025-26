var builder = WebApplication.CreateBuilder(args);
// Add services to the container.


var app = builder.Build();
// użycie różnych  elementów middleware
app.UseStaticFiles();
string info  = "This is my first  example";
app.MapGet("/", () => "Hello World!");
app.MapGet("/ping", () => "<p>pong</p>");
app.MapGet("/info", () => info);
app.Run();
