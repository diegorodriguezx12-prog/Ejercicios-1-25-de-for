Console.Write("¿Cuántas ventas realizaste?: ");
int n = int.Parse(Console.ReadLine());
double totalVentas = 0;

for (int i = 1; i <= n; i++)
{
    Console.Write($"Monto de la venta {i}: ");
    totalVentas += double.Parse(Console.ReadLine());
}
Console.WriteLine($"El gran total de ventas es: {totalVentas:C}");