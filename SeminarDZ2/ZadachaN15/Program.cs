//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число ");
int numDate = Convert.ToInt32(Console.ReadLine());
if(numDate == 1)
{
    Console.WriteLine("Понедельник. До выходного еще далеко..");

}
if(numDate == 2)
{
    Console.WriteLine("Вторник. До выходного все еще далеко.");

}
if(numDate == 3)
{
    Console.WriteLine("Среда. Уже прошли половину, но все же далеко.");

}
if(numDate == 4)
{
    Console.WriteLine("Четверг. Уже совсем чуть-чуть");

}
if(numDate == 5)
{
    Console.WriteLine("Пятница. Вы на финишной прямой");

}
if(numDate == 6)
{
    Console.WriteLine("Суббота. УРА! Выходной.");

}
if(numDate == 7)
{
    Console.WriteLine("Воскресенье. УРА! Выходной.");

}
if(numDate < 1 || numDate > 7)
{
    Console.WriteLine("Ошибка! Введите другое число");
}