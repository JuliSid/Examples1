// GПолучили число и на выходе получили сумму из чисел до этого числа

Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сумма чисел равна = "+ GetSum(num));

int GetSum(int number)
{
    int count = 0;
    int sum = 0;
    while(count < number)
    {
        count++;
        sum+=count;  // sum=sum+count;
    }
    return sum;
}
