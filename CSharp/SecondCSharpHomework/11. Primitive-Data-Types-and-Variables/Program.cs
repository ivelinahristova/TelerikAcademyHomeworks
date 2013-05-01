using System;

class ExchangeValues
{
    static void Main()
    {
        int numberOne, numberTwo;
        Console.Write("Enter number one:");
        numberOne = int.Parse(Console.ReadLine());
        Console.Write("Enter number two:");
        numberTwo = int.Parse(Console.ReadLine());
        numberOne += numberTwo;
        numberTwo = numberOne-numberTwo;
        numberOne -= numberTwo;
        Console.WriteLine("number one = {0}\nnumber two = {1}", numberOne, numberTwo);
    }
}
