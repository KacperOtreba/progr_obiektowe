namespace lekcja_14._11._2023;
class Program
{
    static void Main(string[] args)
    {
        
        // funkcja statyczna, która pozwala wprowadzić rozmiar tablicy i nazwę CreateArray()
        // funkcja statyczna, która ustawia elementy tablicy SetArray()
        // funkcja statyczna, która wyświetla zawartość tablicy DisplayArray()
    }
    public static int[] CreateArray(string name){
        System.Console.Write($"Podaj rozmiar tablicy {name}: ");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];
        return array;
        
    }
    
}
