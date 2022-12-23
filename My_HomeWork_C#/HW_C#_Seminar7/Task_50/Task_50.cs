/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> числа с такими индексами в массиве нет
*/

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] CreateRandom2DArray(int rows, int columns)
{
    int[,] array = new int[rows,columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(1,10);
        }
    }
    return array;
}

void ShowIndex(int[,] array, int a, int b)
{
    Console.Write(array[a,b]);
}

Console.Clear();
Console.WriteLine("Задайте количество строк:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов:");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateRandom2DArray(rows, columns);
Show2dArray(myArray);

Console.WriteLine("Введите номер индекса строки");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер индекса столбца");
int b = Convert.ToInt32(Console.ReadLine());

if (a >= rows && b >= columns)
    Console.WriteLine("Такого числа в массиве нет");
else if (a < rows && b >= columns)
    Console.WriteLine("Такого числа в массиве нет");
else if (a >= rows && b < columns)
    Console.WriteLine("Такого числа в массиве нет");
else
ShowIndex(myArray, a, b);