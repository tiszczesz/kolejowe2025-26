using cw8_mvc_files.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
//builder.Services.AddScoped<IBooksRepo, FileBooksRepo>();
builder.Services.AddScoped<IBooksRepo, SqliteBooksRepo>();
builder.Services.AddScoped<IFishRepo, SqliteFishRepo>();

var app = builder.Build();
app.UseStaticFiles();
//app.MapGet("/", () => "Hello World!");
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Library}/{action=List}/{id?}"
    );

app.Run();
