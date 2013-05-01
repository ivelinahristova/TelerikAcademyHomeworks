using System;

class NullValues
{
    static void Main()
    {
        int? i=null;
        byte? b=null;
        float? f=null;
        double? d=null;
        Console.WriteLine("{0}\n{1}\n{2}\n{3}", i, b, f, d);
        i = 1;
        b = 2;
        f = 3;
        d = 4;
        Console.WriteLine("{0}\n{1}\n{2}\n{3}", i, b, f, d);
    }
}
