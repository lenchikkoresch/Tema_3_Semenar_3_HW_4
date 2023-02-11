/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/
int GetNumber(string messge)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(messge);
        if(int. TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Вели не корректное число");
        }
    }
    return result;
}


double GetDegree (int A, int B)
{
    double C = Math.Pow(A,Math.Abs(B));
return C;
}
int A = GetNumber ("Введите число А");
int B = GetNumber ("Введите число B");
double C = GetDegree (A, B);
Console.WriteLine($"Число {A} в натуральной степени {B} равно {C}");

