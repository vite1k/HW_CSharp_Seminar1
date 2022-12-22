/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

int CountNumbers(int a)
{
    int PosNum = 0;
    
    for (int count = 0; a >= count + 1; count++)
    {
        Console.Write("Введите число: ");
        int b = Convert.ToInt32(Console.ReadLine());        
        if(b > 0)
            PosNum++;
    }
    return PosNum;
}

Console.Write("Сколько чисел планируете ввести? ");
int a = Convert.ToInt32(Console.ReadLine());

int result = CountNumbers(a);
Console.WriteLine($"Количество введённых вами чисел больше 0 -> {result}");