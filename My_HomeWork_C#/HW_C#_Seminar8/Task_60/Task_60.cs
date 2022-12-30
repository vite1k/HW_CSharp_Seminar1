/*
Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

bool CheckRepeat(int[,,] matrix, int digit)
{
    int length = matrix.GetLength(0);
    int width = matrix.GetLength(1);
    int height = matrix.GetLength(2);
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < width; j++)
        {
            for (int k = 0; k < height; k++)
            {
                if (digit == matrix[i, j, k]) return true;
            }
        }
    }
    return false;
}

void PrintArray(int[,,] array)
{
    int length = array.GetLength(0);
    int width = array.GetLength(1);
    int height = array.GetLength(2);
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < width; j++)
        {
            for (int k = 0; k < height; k++)
            {
                Console.Write($"{array[i, j, k]} ({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
    }
}

void FillArray(int[,,] array, int minValue, int maxValue)
{
    int length = array.GetLength(0);
    int width = array.GetLength(1);
    int height = array.GetLength(2);
    int randNumber = 0;
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < width; j++)
        {
            for (int k = 0; k < height; k++)
            {
                while (CheckRepeat(array, randNumber))
                {
                    randNumber = new Random().Next(minValue, maxValue);
                }
                array[i, j, k] = randNumber;
            }
        }
    }
}

Console.Clear();

Console.WriteLine("Задайте количество матриц:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество строк:");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количство столбцов:");
int z = Convert.ToInt32(Console.ReadLine());

int[,,] array = new int[x, y, z];

if(x * y * z < 89)
{
    FillArray(array, 10, 100);
    PrintArray(array);
}
else
{
    Console.WriteLine("Неповторяющихся чисел недостаточно!");
}