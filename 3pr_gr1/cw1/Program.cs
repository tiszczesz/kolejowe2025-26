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
void zad1()
{
    try
    {
        Console.Write("Pdaj pierwsza liczbe: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Podaj druga liczbe: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Wybierz dzialanie (+, -, *, /): ");
        string? dzialanie = Console.ReadLine()?.Trim();
        dzialanie = dzialanie?.Length > 0 ? dzialanie[0].ToString() : "";
        if (string.IsNullOrEmpty(dzialanie))
        {
            Console.WriteLine("Nie podano dzialania");
            return;
        }
        switch (dzialanie)
        {
            case "+":
                Console.WriteLine($"{a} + {b} = {a + b}");
                break;
            case "-":
                Console.WriteLine($"{a} - {b} = {a - b}");
                break;
            case "*":
                Console.WriteLine($"{a} * {b} = {a * b}");
                break;
            case "/":
                if (b == 0)
                {
                    Console.WriteLine("Nie dzielimy przez zero");
                }
                else
                {
                    Console.WriteLine($"{a} / {b} = {(double)a / b}");
                }
                break;
            default:
                Console.WriteLine("Nieznane dzialanie");
                break;
        }
    }
    catch (FormatException e)
    {
        Console.WriteLine("Bledny format liczby: " + e.Message);
    }
}