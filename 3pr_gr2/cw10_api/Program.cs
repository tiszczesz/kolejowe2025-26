var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/api", () => new { Message = "Hello from the API!" , Date =  DateTime.Now });

app.Run();
