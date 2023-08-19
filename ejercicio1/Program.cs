//Ejercicio1

int n;
do
{
    Console.Write("Ingrese el tamaño del arreglo (minimo 5): ");
}

while (!int.TryParse(Console.ReadLine(), out n) || n < 5);

double[] Stock = new double[n];

for (int i = 0; i < Stock.Length; i++)
{
    Console.Write($"Ingrese el valor: ");
    Stock[i] = double.Parse(Console.ReadLine());
}

Console.WriteLine("Valores ingresados: ");
foreach (int i in Stock)
{
    Console.WriteLine($">{i}");
}