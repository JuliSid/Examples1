// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int size = Convert.ToInt32(Console.ReadLine());
while (size < 1)
{
    Console.Write("Введите размер массива: ");
    size = Convert.ToInt32(Console.ReadLine());
}
int maxNumber = size * size;
int number = 1;
int[,] matrix = new int[size, size];
int i = 0;
int j = 0;
while (number <= maxNumber)
{
    int i1 = i;
    int j1 = j;
    if (number == maxNumber)
    {
        matrix[i, j] = number;
        number++;
    }
    else
    {
        while (j < size - 1)
        {
            matrix[i, j] = number;
            number++;
            j++;
        }
        while (i < size - 1)
        {
            matrix[i, j] = number;
            number++;
            i++;
        }
        while (j > j1)
        {
            matrix[i, j] = number;
            number++;
            j--;
        }
        while (i > i1)
        {
            matrix[i, j] = number;
            number++;
            i--;
        }

        size = size - 1;
        i++;
        j++;
    }
}

Console.Clear();
printMatrix(matrix);


void printMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
