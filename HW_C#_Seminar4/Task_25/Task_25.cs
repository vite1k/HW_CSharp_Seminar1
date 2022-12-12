/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int Exponention(int a, int b)
{
    int n = a;

    for(int count = 1; b > count; count++)
        n = n * a;

    return n;
}

Console.Write("Введите число, которое требуется возвести в степень: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int result = Exponention(num1, num2);
Console.WriteLine($"Число {num1} в степени {num2} будет {result}");