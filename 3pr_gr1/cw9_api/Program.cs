var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/api/", () => 
     new { Name = "John Doe", Age = 30,Date = DateTime.Now  });

app.Run();
