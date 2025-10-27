var builder = WebApplication.CreateBuilder(args);
//dodawanie nowych usług do kontenera
//dodawanie  Razor Pages itp.
builder.Services.AddRazorPages();

var app = builder.Build();
//konfigurowanie potoku przetwarzania żądań HTTP
app.UseStaticFiles();
var info = "Ala ma kota";
//app.MapGet("/", () => "Hello World!");
app.MapRazorPages();
app.MapGet("/first", () => "Hello First!");
app.MapGet("/info", () => info.ToUpper());
app.MapGet("/data", () => DateTime.Now.ToShortDateString());

app.Run();
