//Написать программу масштабирования фигуры

void Fillarray (double[,] array, int min, int max)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)       
        array[i,j] = random.Next(min, max);
}

void Printarray (double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
       Console.Write($"({array[i,0]}; {array[i,1]}) ");
       Console.WriteLine();
}

void Newarray(double[,] array, double k)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
           array[i,j] = array[i,j] * k;    
}

double [,] array = new double [4,2];
Console.WriteLine("Изначальные коориднаты фигуры: ");
Fillarray(array, 0, 10);
Printarray(array);
Console.Write("Введите коэффициент масштабирования: ");
double k = double.Parse (Console.ReadLine() ?? "0");
Console.WriteLine("Координаты после масштаирования: ");
Newarray(array, k);
Printarray(array);

