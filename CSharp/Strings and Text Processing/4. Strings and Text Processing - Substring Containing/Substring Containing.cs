using System;
using System.Text;
class SubstringContaining
{
    static void Main()
    {
        int counter = 0;
        Console.Write("Enter text:");
        string str = Console.ReadLine();
        Console.Write("Enter string to search:");
        string search = Console.ReadLine();
        for (int i = 0; i < str.Length - search.Length; i++)
        {
            if (str.Substring(i, search.Length).ToLower()==search.ToLower())
            {
                counter++;
                i++;
            }
        }
        Console.WriteLine(counter);
    }
}