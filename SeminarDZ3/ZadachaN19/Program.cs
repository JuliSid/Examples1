﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите  число");
int num = Convert.ToInt32(Console.ReadLine());
string num2 = Convert.ToString(num);
 
 if(num>= 10000 && num<=100000)
 {
    if(num2[0] ==num2[4] && num2[1] ==num2[3])
    {
        Console.WriteLine("Является палиндромом");
    }
    else
    {
        Console.WriteLine("Не является палиндромом");
    }
 }

Console.WriteLine("Число не входит в промежуток");
    






















// string str = Console.ReadLine();
// int length = str.Length;
// string str3 = str.Substring(0, str.Length/2 +1);
// int length2 = str3.Length;


// if(str3 != str)
// {
       
//     for(int i = 0; i < length/2; i++)
//         {
//             Console.Write(str[length - 1- i]);
//         }
     
//      for(int d =0; d<length2/2; d++)
//         {
//             Console.Write(str3[length2-1-d]);
//         }

//      Console.Write("  Число не палиндром");
//     }
//  else
//         {
//             Console.WriteLine("Число палиндром");
//         }  
     
 

