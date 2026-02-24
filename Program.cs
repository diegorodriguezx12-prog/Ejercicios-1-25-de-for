int contador = 0;
for (int i = 1; i <= 5; i++)
{
    Console.Write("Ingresa un número: ");
    if (int.Parse(Console.ReadLine()) > 10) contador++;
}
Console.WriteLine("Cantidad de números mayores a 10: " + contador);