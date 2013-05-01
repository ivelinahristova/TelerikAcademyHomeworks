using System;
using System.Text;

class UnicodeCharacters
{
    static void Main()
    {
        Console.Write("Enter text:");
        string text = Console.ReadLine();
        StringBuilder unicode = new StringBuilder();
        for (int i = 0; i < text.Length; i++)
        {
            unicode.Append(string.Format(@"\u{0:X4}", (int)text[i]));
        }
        Console.WriteLine(unicode.ToString());
    }
}
