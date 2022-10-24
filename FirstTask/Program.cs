// Дано число, обозначающее день недели. Выяснить, является номер дня недели выходным.
Console.WriteLine("Введиле номер дня недели (от 1 до 7)");
int number = int.Parse(Console.ReadLine());
if(number < 1 || number > 8)
{
    Console.WriteLine("Введено неверное число");
}
else
{
    if(number > 0 && number < 6)
    {
        Console.WriteLine("Будний день");
    }
    else
    {
        Console.WriteLine("Выходной день");
    }
}