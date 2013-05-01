using System;
using System.Globalization;

class AfterSixHours
{
    static void Main()
    {
        
        Console.Write("Enter date and time in format [day.month.year hh:mm:ss");
        string dateTime = Console.ReadLine();
        //string dateTime = "03.02.2013 00:00:00";
        DateTime date = DateTime.ParseExact(dateTime, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);

        date = date.AddHours(6.3);

        Console.WriteLine("{0} {1}", date.ToString("dddd", new CultureInfo("bg-BG")), date);
    }
}
