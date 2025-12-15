var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();
app.UseStaticFiles();
//app.MapGet("/", () => "Hello World!");
//app.MapDefaultControllerRoute(); //Home/Index
app.MapControllerRoute( //MoviesLib/List
    name: "default",
    pattern: "{controller=MoviesLib}/{action=List}/{id?}"
);

app.Run();
