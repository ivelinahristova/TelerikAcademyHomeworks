using System;

class ChangeBit
{
    static void Main()
    {
        int n,bit,mask=1;
        byte v, p;
        Console.Write("Enter integer number:");
        n = int.Parse(Console.ReadLine());
        Console.Write("Enter value(1 or 0):");
        v = byte.Parse(Console.ReadLine());
        Console.Write("Enter position:");
        p = byte.Parse(Console.ReadLine());
        bit = (mask << p & n);
        bit = bit >> p;
        if (v == bit) Console.WriteLine("Values are equal");
        else
        {
            if (v == 0)
            {
                mask = 1;
                mask = ~(mask << p);
                Console.WriteLine(mask & n);
            }
            else 
            {
                mask = 1;
                mask = mask << p;
                Console.WriteLine(mask | n);
            }
        }
    }
}
