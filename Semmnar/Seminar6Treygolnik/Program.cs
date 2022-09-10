// Напишите программу, которая принимает 3 числа и проверяет, существует ли акоой треугольник

Console.WriteLine("Введите три числа а, б, в" );
double a = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());
double c = Convert.ToDouble(Console.ReadLine());

void GetTri(double a, double b, double c)
{
    if(a<b+c && b< a+c && c <a+b)
    {
        Console.WriteLine("Такой треугольник может существовать");
    }
    else
    {
        Console.WriteLine("Такой треугольник не существовует");
    }
}
GetTri(a,b,c);



// bool GetTri(int a, int b, int c)
// {
//     if(a>b+c)
//     return false;
//     else if(b>a+c)
//     return false;
//     else if(c > a+b)
//     return false;
//     else true;
// }
// bool GetTriy = GetTri(10,2,3);
// {
//     if(GetTri == true)
//     {
//         Console.WriteLine("Такой треугольник может существовать");
//     }
//     else
//     {
//         Console.WriteLine("Такой треугольник не существовует");
//     }
// }
