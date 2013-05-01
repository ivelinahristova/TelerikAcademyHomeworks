using System;

class OddOrEven
{
    static void Main()
    {
        int number;
        Console.Write("Enter number:");
        number = int.Parse(Console.ReadLine());
        if (number % 2 == 0) Console.WriteLine("Even");
        else Console.WriteLine("Odd");

    }
}
