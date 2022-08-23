// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Clear();
for(int numberx = 1; numberx <= number; numberx++)     
if((numberx%2)==0)            
{
Console.WriteLine(numberx);
}