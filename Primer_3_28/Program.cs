﻿/*
Задача 28: Напишите программу, которая принимает на вход число N и 
выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/
/*
int GetNumber(string message)
{
int result = 0;

while (true)
{
Console.WriteLine(message);

if (int.TryParse(Console.ReadLine(), out result) && result >= 1)
{
break;
}
else
{
Console.WriteLine("Ввели не число. Повторите ввод");
}
}
return result;
}
int MultipleNumers (int number)
{
int multi = 1;
for (int i = 1; i <= number; i++)
{
multi = multi * i;
}
return multi;
}

int number = GetNumber("Введите число: ");
int rezult = MultipleNumers(number);
Console.WriteLine(rezult);
*/
/* В решении поменяла тип на long так как это больше число*/

long GetNumber(string message)
{
    long result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (long.TryParse(Console.ReadLine(), out result) && result >=1)
        {
            break;
        }
        else
        {
            Console.WriteLine("Число ввели некорректно.");
        }
    }
    return result;
}

long MultipleNumbers (long number)
{
    long multi = 1;
    for (long i=1; i<=number; i++)
    {
    multi=multi * i;
    }
    return multi;
}

long number = GetNumber("Введите положительное число");
long result1 = MultipleNumbers(number);
Console.WriteLine(result1);
