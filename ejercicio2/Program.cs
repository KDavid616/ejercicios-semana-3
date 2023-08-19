//Ejercicio2

String[] NomCompleto = { "Carlos", "David", "Hernandez", "Rodriguez" };

Console.WriteLine("Valores del arreglo: ");

foreach (var i in NomCompleto)
{
    Console.WriteLine(i);
}

int TamañoArreglo = NomCompleto.Length;

Console.WriteLine($"\nTamaño del arreglo: {TamañoArreglo}");

Console.WriteLine("\nTamaño del arreglo y valores: ");

for (int i = 0; i < TamañoArreglo; i++)
{
    Console.WriteLine($"Posicion {i + 1}: {NomCompleto[i]}");
}