var builder = WebApplication.CreateBuilder(args);
//dodawanie nowych usług do kontenera

var app = builder.Build();
var info = "Ala ma kota";
app.MapGet("/", () => "Hello World!");
app.MapGet("/first", () => "Hello First!");
app.MapGet("/info", () => info.ToUpper());
app.MapGet("/data", () => DateTime.Now.ToShortDateString());

app.Run();
