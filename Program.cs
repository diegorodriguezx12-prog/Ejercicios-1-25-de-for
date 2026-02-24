int pares = 0;
for (int i = 1; i <= 5; i++)
{
    Console.Write("Ingresa un número: ");
    if (int.Parse(Console.ReadLine()) % 2 == 0) pares++;
}
Console.WriteLine("Total de números pares: " + pares);