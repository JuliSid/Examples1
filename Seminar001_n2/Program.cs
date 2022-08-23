Console.WriteLine("Введите число ");
int numberA = Convert.ToInt32(Console.ReadLine());
int sqr = numberA * numberA;
Console.Write("Квадрат числа равен ");
Console.WriteLine(sqr);



// using System;
// using System.Linq;
 
// namespace ConsoleApp112
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.Write($"Кодичество чисел для ввода: ");
//             int N = Convert.ToInt32(Console.ReadLine());
 
//             int[] Arr = new int[N];
 
//             for (int i = 0; i < Arr.Length; i++)
//             {
//                 Console.Write($"{i+1}-й элемент: ");
//                 Arr[i] = Convert.ToInt32(Console.ReadLine());
//             }
 
//             Console.WriteLine($"Входной массив {String.Join(", ", Arr)}");
 
//             int MaxElementInArr = Arr.Max();
 
//             Console.WriteLine($"Максимальный элемент массива из введенных: {MaxElementInArr}");
//         }
//     }
// 