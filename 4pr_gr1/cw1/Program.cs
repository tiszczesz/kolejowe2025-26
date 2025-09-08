var builder = WebApplication.CreateBuilder(args);
var books = new List<string>
{
    "W pustyni i w puszczy",
    "Pan Tadeusz",
    "Lalka"
};

var app = builder.Build();

app.MapGet("/", () => "Duzo pracy przed wami ggg ");
app.MapGet("/inny", () => "inny end point");

app.MapGet("/books", () => books);
app.Run();
