using System;

class TenNumbers
{
    static void Main()
    {
        int i;
        for (i = 2; i < 11; i+=2)
        {
            Console.Write(i + " " + (-(i+1)) + " ");
        }
        Console.WriteLine();
    }
}
