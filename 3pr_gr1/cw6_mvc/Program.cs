var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();
app.UseStaticFiles();
//app.MapGet("/", () => "Hello World!");
// /Home/Index
app.MapDefaultControllerRoute();
// app.MapAreaControllerRoute(
//     name: "AdminArea",
//     areaName: "Admin",
//     pattern: "Admin/{controller=MyAdmin}/{action=Info}/{id?}"
// );

app.Run();
