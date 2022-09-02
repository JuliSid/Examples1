// Принимает число и на выход получает количество цифр в числе

// Решение 1

// Console.WriteLine("Введите число ");
// int num = Convert.ToInt32(Console.ReadLine());
// string result = Convert.ToString(num);
// Console.WriteLine("Количество цифр в числе " +CountNum(result));

// int CountNum(string number)
// {
//     int size = number.Length;
//     return size;
// }




// Решение 2



Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Количество цифр в числе " +CountNum(num));


int CountNum(int number)
{
    int count = 0;
    
    while(number > 0)
    {
        count++;
        number/=10;
    
    }
    return count;
}
