using System;

class CopyRightSymbol
{
    static void Main()
    {
        char copyright;
        copyright = '\u00A9';
        Console.WriteLine("  {0}\n {0}{0}{0}\n{0}{0}{0}{0}{0}", copyright);
    }
}