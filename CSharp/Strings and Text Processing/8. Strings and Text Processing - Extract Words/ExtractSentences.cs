using System;
using System.Text;

class ExtractSentences
{
    static void Main()
    {
        Console.Write("Enter text:");
        string str = Console.ReadLine();
        string[] sentences = str.Split('.');
        StringBuilder newString = new StringBuilder();
        bool flag = false;
        for (int i = 0; i < sentences.Length; i++)
        {
            flag = false;
            if (sentences[i].IndexOf(" in ")>=0)
            {
                flag = true;
            }
            if (sentences[i].IndexOf(" in.") >= 0)
            {
                flag = true;
            }
            if (flag)
            {
                newString.Append(sentences[i] + ". "); 
            }
            
        }
        Console.WriteLine(newString.ToString());
    }
}
