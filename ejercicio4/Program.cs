//Ejercicio3

using System.Threading.Tasks;
String[] Palabras = { "Perro", "Casa", "Cebra", "Tortuga",
    "Burro", "Mar", "Dedo", "Tasa", "Nube", "Sol" };

Console.WriteLine("Arreglo sin ordenar: ");
for (int i = 0; i < Palabras.Length; i++)
{
    Console.WriteLine($"Posicion {i + 1}: {Palabras[i]}");
}

Array.Sort(Palabras);

Console.WriteLine("\nArreglo ordenado: ");

foreach (string i in Palabras)
{
    Console.WriteLine(i);
}

//Ejercicio4

Console.WriteLine("\nBusqueda con BinarySearch");

String[] PalabrasSearch = { "Sol", "Dedo", "Casa" };

foreach (string m in PalabrasSearch)
{
    int Posicion = Array.BinarySearch(Palabras, m);

    if (Posicion >= 0)
    {
        Console.WriteLine($"La palabra '{m}' se encontro en la posicion {Posicion}");
    }
    else
    {
        Console.WriteLine($"La palabra '{m}' no se encontro en el arreglo");
    }
}