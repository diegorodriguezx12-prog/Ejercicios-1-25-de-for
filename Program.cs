Console.Write("¿De cuántos escalones quieres la escalera?: ");
int escalones = int.Parse(Console.ReadLine());

for (int i = 1; i <= escalones; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}