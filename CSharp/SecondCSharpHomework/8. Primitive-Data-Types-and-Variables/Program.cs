using System;

class Program
{
    static void Main()
    {
        string quoted, nonQuoted;
        quoted = @"the ""use"" of quotations causes difficulties. ";
        nonQuoted = "the \"use\" of quotations causes difficulties. ";
        Console.WriteLine("quoted string: {0} \nnormal string: {1}", quoted, nonQuoted);
    }
}
