// 

int [] arr = {5, 8, 9, 7, 1, 3, 4, 2};
void printArray(int[] array)
{
    int count = array.Length;
    for(int i=0; i<count; i++)
    {
        Console.Write($"{array[i]}");
    }
Console.WriteLine();
}

void selsort(int[] array)
{
    for(int i=0; i < array.Length-1; i++)
    {
        int minPos = i;
        
        for(int j = i+1; j < array.Length; j++)
        {
            if(array[j]< array[minPos]) minPos = j;

        }
        int temporery = array[i];
        array[i]=array[minPos];
        array[minPos] = temporery;

    }
}


printArray(arr);
selsort(arr);

printArray(arr);