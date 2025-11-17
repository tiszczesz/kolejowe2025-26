using cw5_RazorPages.Models;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddRazorPages();//dodanie usługi Razor Pages

var app = builder.Build();
// użycie różnych  elementów middleware
app.UseStaticFiles();
// string info  = "This is my first  example";
 // app.MapGet("/", () => "Hello World!");
// app.MapGet("/ping", () => "<p>pong</p>");
// app.MapGet("/info", () => info);
// app.MapGet("/api/books", () =>
// {
//     return Books.GetSampleBooks();
// });
app.MapRazorPages();//mapowanie stron Razor Pages 
//szukamy pliku index.cshtml w folderze Pages
app.Run();
