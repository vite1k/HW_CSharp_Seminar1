/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

/*
bool CheckPal(int num)
{
    int rev = 0;
    int n = num;

    while (num > 0) 
    {
         rev = rev * 10 + num % 10; 
         num /= 10;
    }

    if (n == rev)
    { 
        Console.WriteLine("Да, это палиндром!");
        return true;
    }
    else
    {
        Console.WriteLine("Нет, это не палиндром!");
        return false;  
    }
}

Console.Write("Введите число для проверки, является ли оно палиндромом: ");
int number = Convert.ToInt32(Console.ReadLine());

bool Palyndrom = CheckPal(number);
*/