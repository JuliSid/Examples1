
Console.WriteLine("Введите первое число ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int num2 = Convert.ToInt32(Console.ReadLine());
int ost = num2%num;

if(ost==0)
{
    Console.WriteLine(num);
    Console.WriteLine(num2);
    Console.WriteLine("Кратное");
}
else
{
    Console.WriteLine(num);
    Console.WriteLine(num2);
    Console.WriteLine("Остаток от деления = "+ost);
}