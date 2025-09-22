//ex1();
void ex1()
{
    //petla for
    for (int i = 0; i < 10; i++)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
}
//ex2();
void ex2()
{
    //petla while
    //oblicza sume liczb losowych az przekroczy 100
    int sum = 100;
    int counter = 0;
    int minValue = int.MaxValue;
    int maxValue = int.MinValue;
    //Random rand = new Random();
    while (sum < 100)
    {
        int randNum = Random.Shared.Next(1, 21);
        if (randNum < minValue) minValue = randNum;
        if (randNum > maxValue) maxValue = randNum;
        counter++;
        sum += randNum;
        Console.Write(randNum + " ");
    }
    if (counter > 0)
    {
        Console.WriteLine("Suma: " + sum);
        Console.WriteLine("Srednia: " + ((double)sum / counter));
        Console.WriteLine("min: " + minValue);
        Console.WriteLine("max: " + maxValue);
    }
    else
    {
        Console.WriteLine("Nie wylosowano zadnej liczby");
    }

}
ex3();
void ex3()
{
    //petla do while
    //podaj nazwe uzytkownika slowem "exit" konczy program
    string? userName;
    do
    {
        Console.Write("Podaj nazwe uzytkownika (exit konczy): ");
        userName = Console.ReadLine();

    } while ((userName?.Trim().ToLower()) != "exit");
}
