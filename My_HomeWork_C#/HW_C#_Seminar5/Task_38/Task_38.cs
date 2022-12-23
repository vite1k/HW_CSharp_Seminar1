/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.
[3 7 22 2 78] -> 76
*/

double[] CreateRandomArray(int size, int minValue, int maxValue)
{
     double[] array = new double[size];
     
    for(int i = 0; i < size; i++)
    {    
        array[i] = Math.Round((new Random().NextDouble() + Convert.ToDouble(new Random().Next(minValue, maxValue))),2); 
    }    
    return array;
}

void WriteArray(double[] array)
{
    Console.Write("[ ");

    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }    

    Console.Write("]");
}

double GetSubtraction(double[] array)
{
    int index_min = 0;
    int index_max = 0;
    
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] > array[index_max])
        index_max = i;
        if(array[i] < array[index_min])
        index_min = i;  
    }        
    return array[index_max] - array[index_min];
    
}

Console.Clear();

Console.Write("Введите количество элементов: ");
int lenght = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное возможное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное возможное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateRandomArray(lenght, min, max);
WriteArray(myArray);
double result = GetSubtraction(myArray);

Console.WriteLine($" -> {Math.Round(result,2)}");