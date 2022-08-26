Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Clear();
int numberNeg = number * (-1);

while(numberNeg <= number)
{
    Console.WriteLine(numberNeg);
    numberNeg++;
}