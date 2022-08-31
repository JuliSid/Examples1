// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите  число");
string str = Console.ReadLine();
int length = str.Length;

for(int i = 0; i < length; i++)
{
    Console.WriteLine(str[length - i - 1]);
    str == str2;
}