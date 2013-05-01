using System;

class NumberDivide
{
    static void Main()
    {
        bool check;
        int number;
        Console.Write("Ënter a number:");
        number = int.Parse(Console.ReadLine());
        check = (number % 7 == 0 && number % 5 == 0);
        Console.WriteLine(check);
    }
}
