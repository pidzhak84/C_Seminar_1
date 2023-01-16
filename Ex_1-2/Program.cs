// Напишите программу, которая будет выдавать название дня недели по заданному номеру.  5 -> Пятница 

Console.Clear();

Console.Write("Введите номер - ");
int day = int.Parse(Console.ReadLine()!);

if (day == 1)
{
    Console.WriteLine("Day - пн");
}
else if (day == 2)
{
    Console.WriteLine("Day - вт");
}
else if (day == 3)
{
    Console.WriteLine("Day - ср");
}
else if (day == 4)
{
    Console.WriteLine("Day - чт");
}
else if (day == 5)
{
    Console.WriteLine("Day - пт");
}
else if (day == 6)
{
    Console.WriteLine("Day - сб");
}
else if (day == 7)
{
    Console.WriteLine("Day - вс");
}