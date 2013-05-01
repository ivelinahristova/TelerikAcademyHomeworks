using System;

class IsSeven
{
    static void Main()
    {
        int number;
        Console.Write("Enter number:");
        number = int.Parse(Console.ReadLine());
        if ((number % 1000) / 100 == 7) Console.WriteLine("Third digit is 7");
        else
            Console.WriteLine("Third digit is not 7");
    }
}