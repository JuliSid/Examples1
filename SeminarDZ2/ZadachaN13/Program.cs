//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите ваше число ");
int num = Convert.ToInt32(Console.ReadLine());
string str = num.ToString();
Console.WriteLine(str[2]);
