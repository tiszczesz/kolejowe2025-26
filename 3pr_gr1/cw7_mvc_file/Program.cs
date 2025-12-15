using cw7_mvc_file.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
//builder.Services.AddScoped<IMoviesRepo, FileMoviesRepo>();
//builder.Services.AddTransient<IMoviesRepo, FileMoviesRepo>();
builder.Services.AddSingleton<IMoviesRepo, FileMoviesRepo>();
var app = builder.Build();
app.UseStaticFiles();
//app.MapGet("/", () => "Hello World!");
//app.MapDefaultControllerRoute(); //Home/Index
app.MapControllerRoute( //MoviesLib/List
    name: "default",
    pattern: "{controller=MoviesLib}/{action=List}/{id?}"
);

app.Run();
