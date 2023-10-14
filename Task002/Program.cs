/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

A (3,6); B(2, 1)-> 5,09
A(7, -5); B(1, -1)-> 7,21 */
using System.Globalization;

/* struct Point{
    int x;
    int y;
}
 */
//Point A,B;

int [] A = new int [2];

Console.WriteLine("Введите координаты X точки A: ");
A[0] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты Y точки A: ");
A[1] = Convert.ToInt32(Console.ReadLine());

int[] B = new int[2];

Console.WriteLine("Введите координаты X точки B: ");
B[0] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты Y точки B: ");
B[1] = Convert.ToInt32(Console.ReadLine());

int res1 = (int) Math.Pow(A[0] - B[0], 2);
int res2 = (int) Math.Pow(A[1] - B[1], 2);
double dist = Math.Sqrt(res1 + res2);

Console.WriteLine(Math.Round(dist, 3));
