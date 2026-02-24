Console.Write("Cantidad de notas: ");
int n = int.Parse(Console.ReadLine());
double suma = 0;

for (int i = 1; i <= n; i++)
{
    Console.Write($"Nota {i}: ");
    suma += double.Parse(Console.ReadLine());
}

double promedioFinal = suma / n;
Console.WriteLine($"Promedio: {promedioFinal}");

if (promedioFinal >= 61)
    Console.WriteLine("Estado: ¡APROBADO!");
else
    Console.WriteLine("Estado: REPROBADO.");