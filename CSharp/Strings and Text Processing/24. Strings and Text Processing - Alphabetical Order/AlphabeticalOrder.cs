using System;
using System.Linq;

public class AlpabeticalOrder
{
    public static void Main()
    {
        string str = Console.ReadLine();
        string[] words = str.Split();

        var sortedWords = words.OrderBy(x => x);
        foreach (var item in sortedWords)
        {
            Console.Write("{0} ", item);
        }
    }
}