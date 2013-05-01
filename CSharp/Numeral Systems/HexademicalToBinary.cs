﻿using System;
using System.Collections.Generic;
using System.Text;
class HexademicalToBinary
{
    static string Convert(string hexNumber)
    {
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < hexNumber.Length; i++)
        {
            switch (hexNumber[i])
            {
                case '0': result.Append("0000"); break;
                case '1': result.Append("0001"); break;
                case '2': result.Append("0010"); break;
                case '3': result.Append("0011"); break;
                case '4': result.Append("0100"); break;
                case '5': result.Append("0101"); break;
                case '6': result.Append("0110"); break;
                case '7': result.Append("0111"); break;
                case '8': result.Append("1000"); break;
                case '9': result.Append("1001"); break;
                case 'A': result.Append("1010"); break;
                case 'B': result.Append("1011"); break;
                case 'C': result.Append("1100"); break;
                case 'D': result.Append("1101"); break;
                case 'E': result.Append("1110"); break;
                case 'F': result.Append("1111"); break;
                default:
                    break;
            }
        }
        return result.ToString();
    }
    static void Main()
    {
        Console.Write("Enter hexademical number:");
        string hexNumber = Console.ReadLine();
        Console.WriteLine("Binary:");
        Console.WriteLine(Convert(hexNumber));
    }
}
