﻿/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
от 1 до N.

5 -> 1, 4, 9, 16, 25.
2 -> 1,4 */

/* System.Console.WriteLine("Введите число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int i = 1;
while (i <= number)
{
    System.Console.Write($"{Math.Pow(i, 2)} ");
    i++;
} */

System.Console.WriteLine("Введите число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

for (int i = 1; i <= number; i++)
    System.Console.Write($"{Math.Pow(i, 2)} ");
    Console.WriteLine();
    System.Console.WriteLine();
    