// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21


Console.WriteLine("Введите хa:");
int xa = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите ya:");
int ya = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите хb:");
int xb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите yb:");
int yb = Convert.ToInt32(Console.ReadLine());

// double S = Math.Sqrt((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya));
// Math.Pow(xb - xa,2)  ,    (xb - xa) * (xb - xa)
double S = Math.Sqrt(Math.Pow(xb - xa,2)+Math.Pow(yb - ya,2));

Console.WriteLine(S);