// Произведение парных крайних чисел в массиве

int[] Array = {5,7,2,1,3};

int[] result = new int[Array.Length/2 + Array.Length%2];

for(int i = 0; i < result.Length; i++)
{
   result[i] = Array[i]*Array[Array.Length - 1 - i];

   if( i == Array.Length - 1 - i)
   {
    result[i] = Array[i];
   }
}
Console.WriteLine(String.Join(", ", result));