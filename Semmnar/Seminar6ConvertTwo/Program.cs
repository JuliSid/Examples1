// Написать программу, которая переведет число из десятичного кода в двоичный

void ConvertNum(int num)
{
    string result =string.Empty;
    while(num>0)
    {
        result = num%2 + result;
        num/=2;
    }
    Console.WriteLine(result);
}
int input = Convert.ToInt32(Console.ReadLine());
ConvertNum(input);

// int value = 4;
// string binary = Convert.ToString(value,2);
// Console.WriteLine(binary);