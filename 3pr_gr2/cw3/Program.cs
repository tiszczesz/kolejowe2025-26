//ex1();
ex2();
void ex1()
{
    //typ[] nazwa = new typ[rozmiar];
    //tablice jednowymiarowe int
    int[] tab1 = new int[5];

    for (int i = 0; i < tab1.Length; i++)
    {
        tab1[i] = i * 2;
    }
    for (int i = 0; i < tab1.Length; i++)
    {
        Console.Write($"{tab1[i]} ");
    }
    //tab1[6] = 12; //błąd - indeks poza zakresem
    string[] tab2 = new string[] { "Ala", "ma", "kota" };
    string[] tab3 = { "Ala", "ma", "kota" };

}
void ex2()
{
    //tablice wielowymiarowe
    //np 2D
    int[,] tab2D = new int[3, 4]; //3 wiersze, 4 kolumny
    tab2D[2, 3] = 34;
    for (int i = 0; i < tab2D.GetLength(0); i++) //GetLength(0) - liczba wierszy
    {
        for (int j = 0; j < tab2D.GetLength(1); j++) //GetLength(1) - liczba kolumn
        {
            tab2D[i, j] = (int)Math.Pow(i + 1, j + 1);
        }
        Console.WriteLine();
    }
    for (int i = 0; i < tab2D.GetLength(0); i++) //GetLength(0) - liczba wierszy
    {
        for (int j = 0; j < tab2D.GetLength(1); j++) //GetLength(1) - liczba kolumn
        {
            Console.Write($"{tab2D[i, j],5} ");
        }
        Console.WriteLine();
    }
}
void ex3()
{
    //tablice tablic
    int[][] tab = new int[3][];//tablica 3 wierszy, każdy wiersz to tablica intów
    tab[0] = new int[2]; //pierwszy wiersz to tablica 2 elementowa
    tab[1] = new int[5];//drugi wiersz to tablica 5 elementowa
    tab[2] = new int[3];//trzeci wiersz to tablica 3 elementowa
    tab[1][3] = 12;
}
