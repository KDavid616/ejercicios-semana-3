//Ejercicio 5

int[] Num = { 4, 10, 45, -67, -7, 25, 89, 64 };

Console.WriteLine("Arreglo en el orden original");

foreach (int m in Num)
{
    Console.WriteLine(m);
}

Array.Reverse(Num);
Console.WriteLine("\nArreglo con Reverse");

foreach (int i in Num)
{
    Console.WriteLine(i);
}

Array.Sort(Num);
Console.WriteLine("\nArreglo con Sort");
foreach (int i in Num)
{
    Console.WriteLine(i);
}