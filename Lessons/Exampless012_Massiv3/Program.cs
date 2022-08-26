void FiiArray(int[] colection)
{
    int length = colection.Length;
    int index = 0;
    while(index < length)
    {
        colection[index]=new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count =col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}


int[] array = new int[10];

FiiArray(array);
PrintArray(array);