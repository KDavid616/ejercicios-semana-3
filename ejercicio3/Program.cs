//Ejercicio3

using System.Threading.Tasks;
String[] Palabras = { "Perro", "Casa", "Cebra", "Tortuga",
    "Burro", "Mar", "Dedo", "Tasa", "Nube", "Sol" };

Console.WriteLine("Arreglo sin ordenar: ");
for (int m = 0; m < Palabras.Length; m++)
{
    Console.WriteLine($"Posicion {m + 1}: {Palabras[m]}");
}

Array.Sort(Palabras);

Console.WriteLine("\nArreglo ordenado: ");

foreach (string i in Palabras)
{
    Console.WriteLine(i);
}