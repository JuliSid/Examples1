// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.WriteLine("Введите размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = new int [size];
for(int i = 0; i < array.Length; i++)
{
array [i] = new Random().Next(0, 100);
}
int min = array[0];
int max = array[0];
int raz = 0;
for(int i = 0; i < array.Length; i++)
{
    if (array[i] < min )
    {
        min = array[i];
    }
    if (array[i] > max)
    {
        max = array[i];
    }
}
raz = max - min;
Console.WriteLine("[{0}]", String.Join(", ", array));
Console.WriteLine(min + " - минимальное :" + max + " - максимальное");
Console.WriteLine("разница =" + raz);