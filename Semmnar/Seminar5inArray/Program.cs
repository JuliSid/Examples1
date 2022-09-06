// Написать программу, которая определяет присутствует ли заданное число в массиве.

Console.WriteLine("Введите длину массива ");
int size = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[size];

for(int i = 0; i < size; i++)
{
    Array[i] = new Random().Next(-9,10);

}

Console.WriteLine("[{0}]", String.Join(", ", Array));

Console.WriteLine("Введите ваше число ");
int numPolsovatel = Convert.ToInt32(Console.ReadLine());
int count = 0;
for(int i = 0; i <size; i++)
{
   if(Array[i] == numPolsovatel) 
   {
    count++;
   }
}
if(count >0)
{
    Console.WriteLine("Данное число есть в количестве" + count);
}
else
{
    Console.WriteLine("Данного числа нет");
}