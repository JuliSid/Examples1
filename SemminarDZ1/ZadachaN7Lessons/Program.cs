// Написать программу, которая на входе принимает трехзначное число и выводить последнее цифру в нем.

Console.WriteLine("Введите трехзназное число ");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 100 || number > 999)
{
Console.WriteLine("Число не трехзначное");
}

else
{
    number = number%10;
    Console.WriteLine("Последняя цифра числа - "+ number);
}
