using System;
using System.Text;

class RemoveLetters
{
    static void Main()
    {
        Console.Write("Enter text:");
        string text = Console.ReadLine();
        StringBuilder str = new StringBuilder(text);

        for (int i = 0; i < str.Length - 1; i++)
        {
            if (str[i] == str[i + 1])
            {
                str.Remove(i, 1);
                i--;
            }
        }
        Console.WriteLine(str);
    }
}