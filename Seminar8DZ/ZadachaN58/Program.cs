//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите количество строк и столбцов для первого массива ");
int rows = Convert.ToInt32(Console.ReadLine());
int column = Convert.ToInt32(Console.ReadLine());

int[,] matrixA = new int[rows, column];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < column; j++)
    {
        matrixA[i, j] = new Random().Next(1, 101);
        Console.Write(matrixA[i, j] + "\t");

    }
    Console.WriteLine();
}
Console.WriteLine("Введите количество строк и столбцов для второго массива ");
int rows2 = Convert.ToInt32(Console.ReadLine());
int column2 = Convert.ToInt32(Console.ReadLine());

int[,] matrixB = new int[rows2, column2];
for (int m = 0; m < rows2; m++)
{
    for (int k = 0; k < column2; k++)
    {
        matrixB[m, k] = new Random().Next(1, 101);
        Console.Write(matrixB[m, k] + "\t");

    }
    Console.WriteLine();
}
Console.WriteLine("Произведение матриц");
int [,] matrixC = new int[rows,column2];
if(rows != column2 || rows2 != column)
{
    Console.WriteLine("Произведение матриц невозможно вычислить. Матрицы не равны");
}
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < column2; j++)
    {
        int sum = 0;

        for (int c = 0; c < column2;c++)
        {
            sum += matrixA[i,c]*matrixB[c,j];
        }
        matrixC[i, j] = sum;

        Console.Write(matrixC[i, j] + "\t");
    }
    Console.WriteLine();
}
