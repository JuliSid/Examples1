Console.WriteLine("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());



if(number1 < number2)
{
    Console.WriteLine("min - "+ number1);
    Console.WriteLine("max - "+ number2);
}

if(number1 > number2)
{
    Console.WriteLine("min - "+ number2);
    Console.WriteLine("max - "+ number1);
}
if(number1 == number2)
{
Console.Write("Числа равны. min = max");
Console.Write(", ");
Console.Write(number2 +" = "+number1);
}



