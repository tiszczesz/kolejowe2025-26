using System;

namespace cw4_class.Models;

public class GetBookFromConsole
{
    public static Book ReadBook()
    {
        Console.Write("Podaj tytul ksiazki: ");
        string title = Console.ReadLine() ?? "";
        Console.Write("Podaj autora ksiazki: ");
        string author = Console.ReadLine() ?? "";   
        Console.Write("Podaj rok wydania ksiazki: ");
        int year = Convert.ToInt32(Console.ReadLine());
        Console.Write("Czy ksiazka jest w formie cyfrowej (true/false): ");
        bool isDigital = Convert.ToBoolean(Console.ReadLine());
        return new Book(title, author, isDigital, year);
    }
}
