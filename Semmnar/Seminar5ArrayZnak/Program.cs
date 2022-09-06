// Замена положительных элементов массива на отрицательные и наоборот

int[] Array = {-8, 5, -2, 4, -1};

for(int i = 0; i < Array.Length; i++)
{
    Array[i]*=(-1);
}
Console.WriteLine("[{0}]", String.Join(", ",Array));