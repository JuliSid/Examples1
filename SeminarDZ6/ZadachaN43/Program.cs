﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.WriteLine("Введите угловой коэффициент К1 ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите угловой коэффициент К2 ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите переменную b1 ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите переменную b1 ");
double b2 = Convert.ToDouble(Console.ReadLine());

if(k1 == k2)
{
    Console.WriteLine("Прямые параллельны. Нет точек пересечения.");
}
else
{
    double x = (b1 - b2) / -(k1 - k2);
    double y = k1 * x + b1;
  
Console.WriteLine($"Пересечение в точке: ({x};{y})");

}