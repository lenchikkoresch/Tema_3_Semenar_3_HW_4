/*
Задача 26: Напишите программу, которая принимает на вход число и 
выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

int GetNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
                else
        {
            Console.WriteLine("Число ввели некорректно.");
        }
    }

    return Math.Abs(result);
}
 
 int LengthNumber(int numberes)
 {string number1 = numberes.ToString();
    int caunt = number1.Length;
    return caunt;
 }

 int numberes = GetNumber("Введите число");
 int caunt = LengthNumber(numberes);
 Console.WriteLine ($"Число {numberes} содержит {caunt} цифр");



