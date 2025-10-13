namespace cw4_class;

public class Book
{
    private string title;
    private string author;
    private bool isDigital;
    private int year;
    public override string ToString()
    {
        return $"Title: {title}, Author: {author}, Year: {year} (Digital: {isDigital})";
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
        this.title = title;
        this.author = author;
        this.isDigital = isDigital;
        this.year = year;
    }
}