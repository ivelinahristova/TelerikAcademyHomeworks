using System;


class HexToInt
{
    static void Main()
    {
        int hex;
        hex = int.Parse("FE", System.Globalization.NumberStyles.HexNumber);
        Console.WriteLine("The value of \"FE\" in decimal is: {0}",hex);

    }
}

