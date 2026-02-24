int mayor = int.MinValue; 
for (int i = 1; i <= 5; i++)
{
    Console.Write("Ingresa un número: ");
    int num = int.Parse(Console.ReadLine());
    if (num > mayor) mayor = num;
}
Console.WriteLine("El número más grande es: " + mayor);