/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int SumNumber(int num)
{
    int sum = 0;

    while(num > 0)
    {
        int n = num % 10;
        num = num / 10;
        sum = n + sum;
    }

    return sum;
}

Console.Clear();

Console.Write("Введите число, сумму цифр которого нужно посчитать: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = SumNumber(a);
Console.Write($"Сумма цифр в числе {a} равна {result}");