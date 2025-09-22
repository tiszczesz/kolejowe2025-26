ex1();
void ex1()
{
    //tablce jednowymiarowe
    //typ[] nazwa = new typ[rozmiar];
    //tablica z inicjalizacja
    string[] colors = { "czerwony", "zielony", "niebieski" };
    foreach (string color in colors)
    {
        Console.Write(color + " ");
    }
    Console.WriteLine();
    int[] numbers = new int[10]; //tablica 10 elementowa 0000000000
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Random.Shared.Next(1, 101);//i * 10;
    }
    //numbers[10] = 44;
    foreach (int number in numbers)
    {
        Console.Write(number + " ");
    }

    Console.WriteLine();
}
