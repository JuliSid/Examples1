// Метод 1

// void Met()
// {
//     Console.WriteLine("Автор ...");
// }
// Met();


// Метод 2
 
//  void Met2(string str)
//  {
//     Console.WriteLine(str);
//  }
//  Met2("Текст");


// Метод 3

// int MET3()
// {
//     return DateTime.Now.Year - 1;

// }
// int Year = MET3();
// Console.WriteLine(Year);


// Метод 4

string Met4(int count, string text)
{
    string result = String.Empty;
    for(int i = 0; i < count; i++)
    {  
        result = result + text;
    }
    return result;
}
string res = Met4(10,"z");
Console.WriteLine(res);