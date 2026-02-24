double suma = 0;
for (int i = 1; i <= 5; i++)
{
    Console.Write($"Ingresa el número {i}: ");
    suma += double.Parse(Console.ReadLine());
}
Console.WriteLine("El promedio es: " + (suma / 5));