using System;

class DistanceBetweenDays
{
    static void Main()
    {
        Console.Write("Enter start date in format [day.month.year]: ");
        DateTime dayStart = DateTime.Parse(Console.ReadLine());
        Console.Write("Enter finish date in format [day.month.year]: ");
        DateTime dayFinish = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("The distance between {0} and {1} is {2} days"
            ,dayStart,dayFinish,(dayFinish-dayStart).TotalDays);
    }
}
