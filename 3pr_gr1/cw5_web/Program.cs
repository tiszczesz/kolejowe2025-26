using cw5_web.Models;

var builder = WebApplication.CreateBuilder(args);
//dodawanie nowych usług do kontenera
//dodawanie  Razor Pages itp.
builder.Services.AddRazorPages();

var app = builder.Build();
//konfigurowanie potoku przetwarzania żądań HTTP
app.UseStaticFiles();
var info = "Ala ma kota";
//app.MapGet("/", () => "Hello World!");
app.MapRazorPages(); //dodanie obsługi Razor Pages Index w katalogu Pages
app.MapGet("/first", () => "Hello First!");
app.MapGet("/info", () => info.ToUpper());
app.MapGet("/data", () => DateTime.Now.ToShortDateString());
app.MapGet("/api/books",()=>Books.GetBooks());

app.Run();
