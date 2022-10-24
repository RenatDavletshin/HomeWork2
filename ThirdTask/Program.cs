// Задать номер четверти, показать диапазоны координат.
Console.WriteLine("Введите от 1 до 4");
int num = int.Parse(Console.ReadLine());

if(num == 1)
{
    Console.WriteLine("1 четверть (x > 0 и y > 0)");
}
else 
    if(num == 2)
    {
        Console.WriteLine("2 четверть (x > 0 и y < 0)");
    }
    else 
        if(num == 3)
        {
            Console.WriteLine("3 четверть (x < 0 и y < 0)");
        }
        else
            if(num == 4)
            {
                Console.WriteLine("4 четверть (x < 0 и y > 0");
            }