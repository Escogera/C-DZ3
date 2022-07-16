// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");
string pali = Console.ReadLine();
void Palindrome(string x)
{
    if (x.Length==5)
    {
        if (x[0]==x[4]&&x[1]==x[3])
        {   
        Console.Write(x+" ->  да");
        }
        else Console.Write(x+" ->  нет");
        
    }
    else Console.WriteLine("Это число не пятизначное");
}
Palindrome(pali);