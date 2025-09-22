//ex1();
ex2();
void ex1()
{
    // for(int i = 1; i < 10; i++)
    // {
    //     Console.WriteLine(i);
    // }
    int sum = 0;
    int counter = 0;
    var rnd = new Random();
    int minValue = Int32.MaxValue;
    int maxValue = Int32.MinValue;
    while (sum < 100)
    {
        counter++;
        int rndNumber = rnd.Next(1, 50);
        if (rndNumber < minValue) minValue = rndNumber;
        if (rndNumber > maxValue) maxValue = rndNumber;
        sum += rndNumber;
        Console.Write($"number: {rndNumber}, counter: {counter}\n");
    }
    Console.WriteLine(
        @$"Final sum: {sum}, Final counter: {counter} 
              avg: {(double)sum / counter} min: {minValue} max: {maxValue}");
}
void ex2()
{
    string? answer;
    do
    {
        Console.Write("Podaj tekst (koniec aby zakonczyc): ");
        answer = Console.ReadLine();        
    } while (answer?.Trim().ToLower() != "koniec");
}