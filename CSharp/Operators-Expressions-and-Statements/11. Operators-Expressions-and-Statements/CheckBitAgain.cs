using System;

class CheckBitAgain
{
    static void Main()
    {
        byte b;
        int i, mask = 1, bit;
        Console.Write("Enter number:");
        i = int.Parse(Console.ReadLine());
        Console.Write("Enter bit's number:");
        b = byte.Parse(Console.ReadLine());
        bit = (mask << b & i);
        bit=bit >> b;
        Console.WriteLine(bit);
    }
}
