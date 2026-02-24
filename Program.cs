Console.Write("¿Cuántos números vas a ingresar?: ");
int cantidad = int.Parse(Console.ReadLine());
int positivos = 0;

for (int i = 1; i <= cantidad; i++)
{
    Console.Write($"Número {i}: ");
    if (int.Parse(Console.ReadLine()) > 0) positivos++;
}
Console.WriteLine($"Ingresaste {positivos} números positivos.");