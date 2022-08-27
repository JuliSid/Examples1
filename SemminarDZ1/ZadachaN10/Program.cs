// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = num/100;
int num3 = num%10;
int num2 =(num-(num1*100)-num3)/10;

if(num > 100 && num < 1000)
{
    Console.WriteLine(num2);
}
else
{
    Console.WriteLine("Ошибка! Введите трехзначное число");
}