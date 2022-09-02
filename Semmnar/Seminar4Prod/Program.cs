// Принимает число и выдает произведение чисел от 1 до N
  



Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Произведение чисел = " + GetProd(num));


int GetProd( int number)
{
    int count = 1;
    int prod = 1;
    while(count < number)
    {
        count++;
        prod*=count;
    }
    return prod;
}



// Решение 2 ??? нЕ решается


// Console.WriteLine("Введите число ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Произведение чисел = " + GetProd(num));


// int GetProd( int number)
// {
//     int prod=1;
//     for(int i=0; i<= number; i++)
//     {
//         prod*=number;
//     }
//     return prod;
// }
