/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и 
выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]*/

/*Start:
Console.WriteLine("Введите массив из 8 чисел, разделенных пробелами, запятыми или точками");
string text = Console.ReadLine()!;
char[] separators = new char[] { ' ', '.', ',' };
string[] splitArray = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

int n = 8;
int[] arr = new int[n];
int resultNumber = 0;

for (int i = 0; i < arr.Length; i++)
{
  if (int.TryParse(splitArray[i], out resultNumber))
  {
    arr[i] = resultNumber;
  }
  else
  {
    Console.WriteLine("Ввели не число или не корректное число. Повторите ввод!");
    Console.WriteLine("-----------");
    goto Start;
  }
}
Console.WriteLine($"Введенный пользователем массив - это {string.Join(", ", arr)}");*/

int [] GreatArray()
{
Console.WriteLine("Введите массив из 8 чисел, разделенных пробелами, запятыми или точками");
string text = Console.ReadLine()!;
char[] spearator = new char[] { ',','.',' '};
string[] splitArray = text.Split(spearator, StringSplitOptions.RemoveEmptyEntries);
int caunt =  splitArray.Length;
int n = caunt;
int[] arr = new int[n];
int resultNumber = 0;

for (int i = 0; i < caunt; i++)
{
  if (int.TryParse(splitArray[i], out resultNumber))
  {
    arr[i] = resultNumber;
  }
  else
  {
    Console.WriteLine("Ввели не число или не корректное число. Повторите ввод!");
      }
      }
      return arr;
}

      

void PrintArray (int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
     Console.Write($"{arr[i]}, ");   
    }
}
int [] a = GreatArray();
PrintArray(a);
