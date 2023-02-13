/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и 
выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]*/

int [] GreatArray()
{
int []Array = new int [8];
Random number = new Random();
for (int i=0;i<Array.Length;i++)
{
   Array[i] = number.Next();
   }
   return Array;
}

void PrintArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
     Console.Write($"{array[i]}, ");   
    }
}
int [] a = GreatArray();
PrintArray(a);



