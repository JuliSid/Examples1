// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


 Console.WriteLine("Введите длину массива ");
int size = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[size];

for(int i = 0; i < size; i++)
{
    Console.WriteLine("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    Array[i] = num;
}

Console.WriteLine("[{0}]", String.Join(", ", Array));
     
int Count = 0;
for(int i = 0; i <size; i++)
{
    if(Array[i]>0) 
    {
    Count++;
    
    }

}

Console.WriteLine(" Количество чисел, больше 0 - " + Count);