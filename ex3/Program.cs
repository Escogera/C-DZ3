﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("введите число:");
int xx = Convert.ToInt32(Console.ReadLine());
void coub (int a) 
{
    for (int i=1; i<=a; i++)
    {
        Console.Write(i*i*i+" ");
    }  
}
coub (xx);