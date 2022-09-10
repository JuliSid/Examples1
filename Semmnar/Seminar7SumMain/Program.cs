/// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.



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
    double sum =0;
	for(int j=0; j<columns; j++)
	{ 
        
        if(i==j)
        sum+= array[i,j];
		
        Console.Write(array[i,j] + "\t");
	}
	Console.WriteLine();
}
