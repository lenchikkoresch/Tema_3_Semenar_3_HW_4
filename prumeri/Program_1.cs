/*Задача 24: Напишите программу, которая принимает на вход число (А) и 
выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
1. Получить число с консоли.
2. Посчитать сумму.
3. Вывести результат на экран.
*/

int GetNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine (message);
        if (int.TryParse (Console.ReadLine(), out result) && 0<result)
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


int GetSum (int number)
{
int sum = 0;
for (int i = 1; i <= number; i++)
{
   sum=sum+i; 
}
    return sum;
}

int number = GetNumber ("Введите положительное число");
int sum = GetSum (number);
Console.WriteLine ($"Cумма чисел от 1 до {number} равна {sum}");





