Console.Write("¿Cuántas notas vas a promediar?: ");
int n = int.Parse(Console.ReadLine());
double sumaNotas = 0;

for (int i = 1; i <= n; i++)
{
    Console.Write($"Nota {i}: ");
    sumaNotas += double.Parse(Console.ReadLine());
}
double promedio = sumaNotas / n;
Console.WriteLine($"El promedio final es: {promedio:F2}");