// собрать строку с числами от а до б, а<=b
// Метод 1 обычный

// string NumberFor(int a, int b)
// {
//     string result = String.Empty;
// for( int i =a; i<=b; i++)  //  int i =a; i>=b; i--
//     {
//         result+= $"{i}";
//     }
//     return result;
// }

// Метод 2 с помощью рекурсии

// string NumberFor(int a, int b)
// {
//     if( a<=b) return $"(a)" + NumberFor(a+1,b); // if( a<=b) return NumberFor(a+1,b) + $"(a)";
//     else return string.Empty;
// }
// Console.WriteLine(NumberFor(1,10));



// Сумма чисел от 1 до N

//Метод 1 обычный

// int SumFor(int n)
// {
//     int result=0;
//     for( int i =1; i<=n; i++)
//     {
//         result+=i;
//         return result;

//     }
// }



// Метод 2 с помощью рекурсии
 int SumFor(int n)
{
    if(n==0) return 0;
    else return n+SumFor(n-1);
}
Console.WriteLine(SumFor(10));


//Факториал числа

//Метод 1 обычный


int FactirialFor(int n)
{
    int result=1;
    for(int i=0; i <=n; i++)
    {
        result*=i;
    }
    return result;
}


// Метод 2 с помощью рекурсии

// int FactirialFor(int n)
// {
//     if(n == 1) return 1;
//     else return n * FactirialFor(n -1);
// }

// Console.WriteLine(FactirialFor(10));


// Возвести а в степень

//Метод 1 обычный

// int PowerFor(int a, int n)
// {
// int result = 1;
// for(int i = 1; i<= n; i++) result*=a;
// return result;
// }

// Метод 2 с помощью рекурсии

// int PowerFor(int a, int n)
// {
//     //return n == 0 ? 1 PowerFor(a, n - 1) * a;
//     if(n == 0) return 1;
//     else return PowerFor(a, n - 1) * a;
// }

// Console.WriteLine(PowerFor(2,10));


// Метод 3 с помощью рекурсии и мат.формул

// int PowerFor(int a, int n)
// {
//     if(n == 0) return 1;
//     else if( n % 2 == 0) return PowerFor(a*a, n/2);
//     else return PowerFor(a, n - 1) * a;
// }
// Console.WriteLine(PowerFor(2,10));






// int n=1;


// vois FindWords( string alphavet, char [] word, int length = 0 )
// {
//     if(length == word.Length)
//     {
//         Console.WriteLine($"{n++} {new String(word)}"); return;
//     }
//     for(int i = 0; i< alphavet.Length; i++)
//     {
//         word[length]=alphavet[i];
//         FindWords(alphavet, word, length + 1);
//     }
// }
// FindWords("аисв", new char[5]);



// Рекурсия для объода директории


// void CatalogInfo(string path, string index = "")
// {
//     DirectoryInfo catalog = new DirectoryInfo(path);
//     DirectoryInfo[] catalogs = catalog.GetDirectories();
//     for(int i=0; i<catalogs.Length; i++)
//     {
//         Console.WriteLine($"{index}{catalogs[i].Name}");
//         CatalogInfo(catalogs[i].FullName, index + " ");
//     }
//     FileInfo[] files = catalog.GetFiles();
//     for( int i=0; i<files.Length; i++)
//     {
//          Console.WriteLine($"{index}{files[i].Name}");
//     }
// }
// string path = @"D:\LessonsC1\Lessons";
// CatalogInfo(path);



// Рекурсия для пирамидок

// void Towers(string with = "1",string on = "3", string some = "2", int count = 3)
// {
//     if(count>1) Towers(with,some,on,count-1);
//     Console.WriteLine($"{with}>>{on}");
//     if(count>1) Towers(with,on,some,count-1);

// }
// Towers();




// обход дерева функции с помощю рекурсии


string emp = String.Empty;
string[] tree = {emp , "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3"};
//                0     1    2     3    4    5    6    7    8    9    10   11

void InOrderTravalsal(int pos =1)
{
    if(pos< tree.Length)
    {
        int left = 2 * pos;
        int right = 2*pos+1;
        if(left<tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTravalsal(left);
        Console.WriteLine(tree[pos]);
        if(right<tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTravalsal(right);
    }
}
InOrderTravalsal();
