// вывести массив

// int[] array = new int[8];

// void FillArray(int[] collection)
// {
//     int length = collection.Length;
//     int index = 0;
//     while(index < length)
//     {
//         collection[index] = new Random().Next(0,2);
//         index++;
//     }
// }

// void PrintArray(int[] col)
// {
//     int count =col.Length;
//     int position = 0;
//     while(position<count)
//     {
//         Console.Write(col[position]);
//         position++;
//     }
// }

// FillArray(array);
// PrintArray(array);




int[] array = GetArray(8);
Console.WriteLine(string.Join(",", array));

int[] GetArray(int size)
{
    int[] result =new int[size];
    for(int i=0; i<size; i++)
    {
        result[i] = new Random().Next(0,2);

    }
    return result;
}