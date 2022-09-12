// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет


Console.WriteLine("Введите номер строки:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца:");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int rows = new Random().Next(0, 11);
int column = new Random().Next(0, 11);

int[,] matrix = new int[rows, column];

for (int i = 1; i < rows; i++)
{
    for (int j = 1; j < column; j++)
    {
        matrix[i, j] = new Random().Next(1, 101);
        Console.Write(matrix[i, j] + "\t");
    }

    Console.WriteLine();
}

if (x > rows || y > column && x <rows)
{
    Console.WriteLine("Данная позиция отсутствует!");
}
if (x < rows && y < column)
{
    Console.Write("В данной позиции находится : ");
    Console.WriteLine(matrix[x,y]);
}
