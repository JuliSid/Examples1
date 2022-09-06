// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите длину массива ");
int size = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[size];

for(int i = 0; i < size; i++)
{
    Array[i] = new Random().Next(1,1000);

}
Console.WriteLine("[{0}]", String.Join(", ", Array));

int Count = 0;
for(int i = 1; i <size; i=i+2)
{
    Count = Count + Array[i];
    
 
}

Console.WriteLine("Сумма нечетных чисел - " + Count);