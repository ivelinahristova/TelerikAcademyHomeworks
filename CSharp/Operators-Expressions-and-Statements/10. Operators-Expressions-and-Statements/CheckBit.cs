using System;

class CheckBit
{
    static void Main()
    {
        byte p;
        int v,mask=1;
        bool bit;
        Console.Write("Enter number:");
        v = int.Parse(Console.ReadLine());
        Console.Write("Enter bit's number:");
        p = byte.Parse(Console.ReadLine());
        bit = ((mask << p & v) != 0 ? true : false);
        Console.WriteLine(bit);
    }
}
