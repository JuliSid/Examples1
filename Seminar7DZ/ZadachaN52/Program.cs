﻿// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine()); ;

Console.WriteLine();
int[,] matrix = new int[rows, columns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(0, 11);
        Console.Write(matrix[i, j] + "\t");

    }
    Console.WriteLine();
}

Console.WriteLine("Среднее арифметическое");

for (int j = 0; j < columns; j++)
{
    double sum = 0;

    for (int i = 0; i < rows; i++)
    {
        sum = sum + matrix[i, j];
    }
    Console.Write(Math.Round(sum / columns, 2) + "\t");
}
Console.WriteLine();