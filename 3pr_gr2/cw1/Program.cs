//ex1();
ex2();
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
}