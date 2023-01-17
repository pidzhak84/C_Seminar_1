// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру
// этого числа. 456 -> 6, 782 -> 2, 918 -> 8

Console.Clear();

Console.Write("Эй, ты, число введи ");
int number = int.Parse(Console.ReadLine()!);
if(number<0)
{number = number * (-1);}
Console.WriteLine(number%10);
