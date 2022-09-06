// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


Console.WriteLine("Введите длину массива ");
int size = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[size];

for(int i = 0; i < size; i++)
{
    Array[i] = new Random().Next(100,1000);

}
Console.WriteLine("[{0}]", String.Join(", ", Array));

int sumCount = 0;
for(int i = 0; i <size; i++)
{
    if(Array[i]%2==0) 
    {
    sumCount++;
    
    }

}

Console.WriteLine(" Четных чисел - " + sumCount);