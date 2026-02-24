int menor = int.MaxValue;
for (int i = 1; i <= 5; i++)
{
    Console.Write("Ingresa un número: ");
    int num = int.Parse(Console.ReadLine());
    if (num < menor) menor = num;
}
Console.WriteLine("El número más pequeño es: " + menor);