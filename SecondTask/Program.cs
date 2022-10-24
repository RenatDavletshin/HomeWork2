// По двум заданным числам проверять, является ли одно квадратом другого.
Console.Write("Введите первое число: ");
int numA = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numB = int.Parse(Console.ReadLine());
if(numA == numB * numB)
{
    Console.WriteLine($"{numA} является квадратом {numB}");
}
else
    if(numB == numA * numA)
    {
        Console.WriteLine($"{numB} является квадратом {numA}");
    }
    else
    {
        Console.WriteLine("False");
    }