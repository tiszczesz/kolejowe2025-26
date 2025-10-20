namespace cw4_class.Models;

public class Book
{
    private string title;
    private string author;
    private bool isDigital;
    private int year;
    public int Id { get; set; }
    public override string ToString()
    {
        return $"Title: {Title}, Author: {Author}, Year: {year} (Digital: {isDigital})";
    }
    public Book()
    {
        title = "Unknown Title";
        author = "Unknown Author";
        isDigital = false;
        year = DateTime.Now.Year;
    }
    public Book(string title, string author, bool isDigital, int year)
    {
        Title = title;
        Author = author;
        this.isDigital = isDigital;
        Year = year;
    }
    //properties
    public string Title
    {
        get { return title.ToUpper(); }
        set { title = value.Trim(); }
    }
    public string Author
    {
        get { return author; }
        set { author = value.Trim(); }
    }
    public int Year
    {
        get { return year; }
        set
        {
            year = (value < 0) ? 0 : value;
        }
    }
    public void ShowInfo()
    {
        Console.WriteLine(this);
    }
    public bool IsDigital
    {
        get { return isDigital; }
        set { isDigital = value; }
    }
    //todo other properties
}