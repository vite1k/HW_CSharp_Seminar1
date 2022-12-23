/* 
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
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

int GetSumOfOddNumbers(int[] array)
{
    int sum = 0;

    for (int i = 1; i < array.Length; i += 2)
    {
        sum = sum + array[i];
    }        
    return sum;
}

Console.Clear();

Console.Write("Введите количество элементов: ");
int lenght = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное возможное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное возможное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(lenght, min, max);
WriteArray(myArray);
int result = GetSumOfOddNumbers(myArray);

Console.WriteLine($" -> {result}");