var builder = WebApplication.CreateBuilder(args);
//dodawanie pakietow do serwisu

//dodawanie kontrolerów i widoków
builder.Services.AddControllersWithViews();

var app = builder.Build();
//dodatkowa konfiguracja
app.UseStaticFiles();
//app.MapGet("/", () => "Hello World!");
app.MapDefaultControllerRoute();
app.Run();
