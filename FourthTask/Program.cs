// Найти расстояние между точками в пространстве 2D/3D.
Console.WriteLine("Введите X1: ");
int X1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Y1: ");
int Y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Z1: ");
int Z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите X2: ");
int X2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Y2: ");
int Y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Z2: ");
int Z2 = int.Parse(Console.ReadLine());
double distance = Math.Sqrt((X2 - X1)*(X2 - X1)+(Y2 - Y1)*(Y2 - Y1)+(Z2 - Z1)*(Z2 - Z1));
Console.Write("Расстояние между точками равно: ");
Console.Write(distance);