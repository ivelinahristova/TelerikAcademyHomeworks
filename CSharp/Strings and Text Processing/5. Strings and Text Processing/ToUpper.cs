﻿using System;
using System.Text.RegularExpressions;

class ToUpper
{
    static void Main()
    {
        Console.Write("Enter text:");
        string str = Console.ReadLine();

        Console.WriteLine(Regex.Replace(str, "<upcase>(.*?)</upcase>", m => m.Groups[1].Value.ToUpper()));
    }
}