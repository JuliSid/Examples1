//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[rows,columns];

Console.WriteLine("Первоначальный массив:");
for(int i=0; i<rows; i++)
{
	for(int j=0; j<columns; j++)
	{
		array[i, j] = new Random().Next(1, 100);
		Console.Write(array[i,j] + "\t");
	}
	Console.WriteLine();
	
}
Console.WriteLine();

Console.WriteLine("Измененный массив:");
for(int i=0; i<rows; i++)
{
	for(int j=0; j<columns; j++)
	{
		if(i%2==0 && j%2==0)
		{
			array[i,j]=Math.Pow(array[i,j], 2);
		}
		Console.Write(array[i,j] + "\t");
	}
	Console.WriteLine();
}

