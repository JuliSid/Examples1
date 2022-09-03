// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сумма цифр в числе = " + SumCountNum(num));


int SumCountNum(int number)
{
    int count = 0;
    
   while (number > 0)
    {
        count = count + number % 10;
        number = number /10 ;
    }
 
    return count;
}


