/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

string ReadLine(string text)
{
    Console.Write(text);
    var result = Console.ReadLine();
    return result;
}

int ShowNum(int num1, int num2)
{
    if(num1 < num2) return num1 + ShowNum(num1 + 1, num2);  
    if(num1 > num2) return num1 + ShowNum(num1 - 1, num2);
    return num2;
}

Console.Clear();
int m = Convert.ToInt32(ReadLine("Введите первое число: "));
int n = Convert.ToInt32(ReadLine("Введите второе число: "));

int res = ShowNum(m, n);
Console.WriteLine(res);