using cw2_ef.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var connString = builder.Configuration.GetConnectionString("sqlite");
builder.Services.AddDbContext<BooksContext>(
    op =>op.UseSqlite(connString)
    );
var app = builder.Build();
app.UseStaticFiles();
//app.MapGet("/", () => "Hello World!");
app.MapDefaultControllerRoute();
app.Run();
