// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


Console.WriteLine("Введите число  ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень  ");
int numB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ваше число в степени = " + GetPOW(numA,numB));


double GetPOW(int number, int number2)
 {
    double prod = (Math.Pow(number,number2));
    return prod;
 }

