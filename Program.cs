int suma = 0;
for (int i = 1; i <= 3; i++)
{
    Console.Write($"Ingresa el número {i}: ");
    suma += int.Parse(Console.ReadLine());
}
Console.WriteLine("La suma total es: " + suma);