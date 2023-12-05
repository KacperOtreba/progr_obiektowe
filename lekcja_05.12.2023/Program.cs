namespace lekcja_05._12._2023;
class Program
{
    static void Main(string[] args)
    {
        // // tworzenie listy liczb całkowitych
        // List<int> ints = new List<int>();

        // // tworzenie listy liczb z początkowymi elementmai, używając inicjalizatora kolekcji
        // List<int> ints1 = new List<int>() {1,2,1,10,-2};

        // // dodawanie elementów do listy za pomocą metody Add()
        // ints1.Add(1);
        // ints1.Add(111);

        // // usuwanie elementu z listy za pomocą metody Remove()
        // ints1.Remove(1);

        // // wyświetlanie listy za pomocą właściwości Count
        // System.Console.WriteLine("Długość listy" + ints1.Count); // 6

        // // wyświetlenie elementów listy za pomocą foreach
        // foreach (int item in ints1)
        // {
        //     System.Console.Write(item+" "); // 2 1 10 -2 1 111
        // }


        // •	Utwórz listę liczb całkowitych i wypełnij ją losowymi wartościami z zakresu od 1 do 100.
        // •	Napisz metodę, która przyjmuje jako parametr listę liczb i zwraca listę liczb, które są podzielne przez 3 lub 5.
        // •	Wyświetl na konsoli listę liczb losowych i listę liczb podzielnych przez 3 lub 5.
        // tworzenie listy liczb całkowitych
        List<int> numbers = new List<int>(10);

        // tworzenie obiektu generatora losowych liczb
        Random r = new Random();

        // wywołanie listy 10 losowych liczb z zakresu 1-100
        for (int i = 0; i < 10; i++)
        {
            numbers.Add(r.Next(1,101));
        }

        // wyświetlanie listy
        System.Console.WriteLine("Lista liczb lowsowych: ");
        foreach (int item in numbers)
        {
            System.Console.Write(item+" ");
        }
        System.Console.WriteLine();

        // sprawdzenie metodą CzyPodzielne() listy numbers oraz wyświetlenie jej
        List<int> podzielne = CzyPodzielne(numbers);
        foreach (int item in podzielne)
        {
            System.Console.Write(item+" ");
        }

    }
    // metoda, która przyjmuje listę liczb i zwraca nową listę liczb podzielnych przez 3 lub 5
    static List<int> CzyPodzielne(List<int> lista){
        List<int> podzielne = new List<int>();
        foreach (int item in lista)
        {
            if (item % 3 == 0 || item % 5 == 0){
                podzielne.Add(item);
            }
        }
        return podzielne;
    }
}
