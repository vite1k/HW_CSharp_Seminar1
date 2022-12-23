/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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

Console.Clear();
Console.WriteLine("Задайте количество строк:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов:");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateRandom2DArray(rows, columns);
Show2dArray(myArray);

for (int i = 0; i < myArray.GetLength(0); i++)
{
    int srAr = 0;

    for (int j = 0; j < myArray.GetLength(1); j++)
    {
        srAr += myArray[j, i];
    }
    double result = (float)srAr / rows;
    result = Math.Round(result, 1);
    Console.WriteLine($"Cреднее арифметическое элементов столбца {i + 1} = {result}");
}