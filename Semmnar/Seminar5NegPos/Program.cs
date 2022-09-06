// Создать масив из 12 чисел и заполнить его положительными и отрицательными числами от -9 до 9

int[] array = new int[12];
int size = array.Length;
int PositivSum = 0;
int NegativSum = 0;

for(int i = 0; i < size; i++)
{
    array[i] = new Random().Next(-9,10);
    if(array[i]>0)
    {
        PositivSum+=array[i];
    }
    else
    {
        NegativSum+=array[i];
    }
}
Console.WriteLine("Сумма положительных чисел равна = "+PositivSum + " | Сумма отрицательных чисел = "+ NegativSum);
Console.WriteLine(String.Join(", ",array));