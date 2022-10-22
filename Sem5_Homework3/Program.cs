//Написать программу копирования массива

void FillArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)    
        array[i] = new Random().Next(-10,10);       
}

void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write ($"|{array[i]}| ");     
}

void CopyingArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
       array[i] = array[i];  
}

Console.Write("Введите длинну массива: ");
int length = int.Parse(Console.ReadLine()?? "0");
int [] array = new int [length];
FillArray (array);
Console.WriteLine("Изначальный массив:");
PrintArray (array);
Console.WriteLine();
CopyingArray(array);
Console.WriteLine ("Скопированный массив:");
PrintArray(array);