//ex1();
//ex2();
ex3();
void ex1()
{
    const string FirstName = "John";
    const string LastName = "Doe";
    Console.WriteLine($"Hello, {FirstName} {LastName}!");
}
void ex2()
{
    Console.Write("Podaj swoje imie: ");
    string? firstName = Console.ReadLine()?.Trim();
    Console.Write("Podaj swoje nazwisko: ");
    string? lastName = Console.ReadLine()?.Trim();
    if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
    {
        Console.WriteLine("Brak danych");

    }
    else
    {
        Console.WriteLine(
            $"Witaj, {firstName} {lastName}" +
            $" dzisiaj mamy: {DateTime.Now.ToShortDateString()}!"
            );
    }
}
void ex3()
{
    //liczby
    try
    {
        Console.Write("Podaj pierwsza liczbe: ");
        int number1 = Convert.ToInt32(Console.ReadLine()?.Trim());
        Console.Write("Podaj druga liczbe: ");
        int number2 = Convert.ToInt32(Console.ReadLine()?.Trim());
        Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
        Console.WriteLine($"{number1} - {number2} = {number1 - number2}");
        Console.WriteLine($"{number1} * {number2} = {number1 * number2}");
        Console.WriteLine($"{number1} / {number2} = "
        + (number2 != 0 ? $"{(double)number1 / number2}" : "Nie dziel przez 0!"));
}
    catch (FormatException ex)
    {
        Console.WriteLine("Bledne dane wejsciowe: " + ex.Message);
    }
}