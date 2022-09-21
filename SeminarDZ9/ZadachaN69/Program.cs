// // Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.Write("Введите неотрицательное число m: ");
double m = Convert.ToDouble(Console.ReadLine());
while (m < 0)
{
    Console.Write("Введите неотрицательное число m: ");
    m = Convert.ToDouble(Console.ReadLine());
}
Console.Write("Введите неотрицательное число n: ");
double n = Convert.ToDouble(Console.ReadLine());
while (n < 0)
{
    Console.Write("Введите неотрицательное число n: ");
    n = Convert.ToDouble(Console.ReadLine());
}
double AckermanFunction(double m, double n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else
    {
        if (n == 0)
        {
            return AckermanFunction(m - 1, 1);
        }
        else
        {
            return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
        }
    }
}

Console.Write(AckermanFunction(m, n));
