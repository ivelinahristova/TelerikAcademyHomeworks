using System;
using System.Text;

class ReplaceForbiddenWords
{
    static void Main()
    {
        Console.Write("Enter text:");
        string str = Console.ReadLine();
        string forbidden = "PHP, CLR, Microsoft";
        string[] forbiddenWords = forbidden.Split(',');
        for (int i = 0; i < forbiddenWords.Length; i++)
        {
            forbiddenWords[i] = forbiddenWords[i].TrimStart();
            if (str.IndexOf(forbiddenWords[i])>=0)
            {
                StringBuilder asterisks = new StringBuilder();
                asterisks.Append('*', forbiddenWords[i].Length);
                str = str.Replace(forbiddenWords[i], asterisks.ToString());
            }
        }
        Console.WriteLine();
        Console.WriteLine(str);
    }
}
