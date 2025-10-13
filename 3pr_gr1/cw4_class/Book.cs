namespace cw4_class;

public class Book
{
    private string title;
    private string author;
    private int year;
    public override string ToString()
    {
        return $"Title: {title}, Author: {author}, Year: {year}";
    }
}