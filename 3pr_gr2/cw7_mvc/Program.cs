var builder = WebApplication.CreateBuilder(args);
//dodajemy obsługę kontrolerów
builder.Services.AddControllersWithViews();
var app = builder.Build();
app.UseStaticFiles();
//app.MapGet("/", () => "Hello World!");
app.MapDefaultControllerRoute();
// app.MapControllerRoute(
//     name: "default",
//     pattern: "{controller=Home}/{action=Index}/{id?}"
//     );
    
app.Run();
