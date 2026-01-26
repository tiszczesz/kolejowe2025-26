using cw8_mvc_files.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
//builder.Services.AddSingleton<IBooksRepo, FileBooksRepo>();
builder.Services.AddSingleton<IBooksRepo, SqliteBooksRepo>();
var app = builder.Build();
app.UseStaticFiles();
//app.MapGet("/", () => "Hello World!");
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Library}/{action=List}/{id?}"
    );

app.Run();
