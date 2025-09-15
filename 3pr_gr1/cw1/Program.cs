//ex1();
//ex2();
//ex3();
zad1();
void ex1()
{
    // See https://aka.ms/new-console-template for more information
    Console.WriteLine("Hello, World!");
    Console.Write("Podaj tekst: ");
    // Console.WriteLine("sadf asa dsa da das");
    string? answer = Console.ReadLine();
    Console.WriteLine("Twoja odpowiedz: " + answer);
    Console.WriteLine($"Twoja odpowiedz: {answer}");
}
void ex2()
{
    //liczby
    try
    {
        Console.Write("Podaj podstawe: ");
        int podstawa = Convert.ToInt32(Console.ReadLine());
        Console.Write("Podaj wykladnik: ");
        int wykladnik = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"{podstawa}^{wykladnik} "
                + $"= {Math.Pow(podstawa, wykladnik)}");
    }
    catch (FormatException e)
    {
        Console.WriteLine("Bledny format liczby: " + e.Message);
    }
}
void ex3()
{
    //podaj tekst i ilosc powtorzen
    try
    {
        Console.Write("Podaj tekst: ");
        string? tekst = Console.ReadLine()?.Trim();
        if (string.IsNullOrEmpty(tekst))
        {
            Console.WriteLine("Nie podano tekstu");
            return;
        }
        Console.Write("Podaj ilosc powtorzen: ");
        int ilosc = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < ilosc; i++)
        {
            Console.WriteLine(tekst);
        }
    }
    catch (FormatException e)
    {
        Console.WriteLine("Bledny format liczby: " + e.Message);
    }
}
void zad1() { }