/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int[] CreateArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        Console.Write("Введите числа массива, нажимая клавишу <<Enter>> после каждого числа: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void WriteArray(int[] array)
{
    Console.Write("[ ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
}

Console.Clear();

Console.Write("Введите количество элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(length);
WriteArray(myArray);