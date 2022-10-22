//Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
Console.Write("Введите значение для k1: ");
double k1 = double.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите значение для k2: ");
double k2 = double.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите значение для b1: ");
double b1 = double.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите значение для b2: ");
double b2 = double.Parse(Console.ReadLine() ?? "0");
double x = (b1-b2)/(k2-k1);
double y = k2*x+b2;


if (k1==k2&&b1==b2)   
{
     Console.WriteLine ("Прямые совпадают");
}
else if (k1==k2)
{
    Console.WriteLine("Прямые параллельны");
}
else
{
    Console.Write($"Координаты точки пересечения двух прямых ({x}; {y})");
}