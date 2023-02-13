/*Задача 27: Напишите программу, которая принимает на вход число и 
выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/

int GetNumber(string messge)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(messge);
        if (int.TryParse(Console.ReadLine(), out result) && result != 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число или некорректное число.");
        }
    }
    return Math.Abs(result);
}

int GetSumNumber(int a, int b)
{
    int sum = 0;
    double c = 1;
    for (int i = b - 1; i >= 0; i--)
    {
        c = Math.Pow(10, i);
        int m = Convert.ToInt32(c);
        sum = sum + ((a / m) % 10);
    }
    return sum;
}

int number = GetNumber("Введите число");
int count = number.ToString().Length;
double sum = GetSumNumber(number, count);

Console.Write($"Сумма цифр введенного числа равна {sum}");

