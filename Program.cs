Console.Write("¿Cuántos números ingresarás?: ");
int n = int.Parse(Console.ReadLine());
int negativos = 0;

for (int i = 1; i <= n; i++)
{
    Console.Write($"Ingresa el número {i}: ");
    if (int.Parse(Console.ReadLine()) < 0) negativos++;
}
Console.WriteLine($"Ingresaste un total de {negativos} números negativos.");