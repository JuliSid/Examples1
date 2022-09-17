// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


bool Contains(int[,,] array, int num)
{
    bool x = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
                if (array[i, j, k] == num)
                {
                    x = true;
                }
        }
    }
    return x;
}

Console.Clear();
Random random = new Random();
int[,,] array = new int[random.Next(2, 6), random.Next(2, 6), random.Next(2, 6)];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            int num = random.Next(10, 100);
            if (Contains(array, num) == true)
            {
                k = k - 1;
            }
            else
            {
                array[i, j, k] = num;
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }

        }
        Console.WriteLine();
    }
    Console.WriteLine();
}