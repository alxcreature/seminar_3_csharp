// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// using System.Globalization;

// Console.Write("Введите число четверти: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num == 1) Console.WriteLine("x>0, y>0");
// else if (num == 2) Console.WriteLine("x<0, y>0");
// else if (num == 3) Console.WriteLine("x<0, y<0");
// else if (num == 4) Console.WriteLine("x>0, y<0");
// else Console.WriteLine("Такой честверти не существует");

/* Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

switch (number)
{
    case 1:
        System.Console.WriteLine("X>0, Y>0");
        break;
    case 2:
        System.Console.WriteLine("X<0, Y>0");
        break;
    case 3:
        System.Console.WriteLine("X<0, Y<0");
        break;
    case 4:
        System.Console.WriteLine("X>0, Y<0");
        break;
    default:
        System.Console.WriteLine("Такой четверти нет");
        break;
} */

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

string[] msg = {
    "X>0, Y>0", // 0
    "X<0, Y>0", // 1
    "X<0, Y<0", // 2
    "X>0, Y<0", // 3
    "Такой четверти нет" // 4
};

if (number > 0 && number < 5) //  5 < 5
    System.Console.WriteLine(msg[number - 1]);
else
    System.Console.WriteLine(msg[4]);