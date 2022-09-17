// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int rows = new Random().Next(1, 11);
int column = new Random().Next(1, 11);

int[,] matrix = new int[rows, column];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < column; j++)
    {
        matrix[i, j] = new Random().Next(1, 101);
        Console.Write(matrix[i, j] + "\t");

    }
    Console.WriteLine();
}
int [] sumMatrix = new int [rows];
for (int i=0;i<rows;i++)
{
    for(int j=0;j<column;j++)
    {
            sumMatrix[i]+=matrix[i,j];
    }        
} 
Console.WriteLine();
Console.WriteLine(string.Join("\t", sumMatrix));   
int minValue = sumMatrix[0];
int minValuei = 1;
for (int i = 0; i < rows; i++)
{
    if(sumMatrix[i] < minValue)
    {
        minValue = sumMatrix[i];
        minValuei = i+1;
    }
}
Console.WriteLine();
Console.WriteLine("Минимальное значение - " + minValue + "  Находится в строке - " + minValuei);
Console.WriteLine();
