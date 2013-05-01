using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
class RemoveTestWords
{
    static void Main()
    {
        string str;
        StringBuilder strTwo = new StringBuilder();
        StringBuilder part = new StringBuilder();
        StreamReader readFile = new StreamReader(@"../../file.txt");
        using (readFile)
        {
            str = readFile.ReadToEnd();
        }
        string[] words;
        words = str.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length>=4)
            {
                if (words[i].Substring(0, 4).CompareTo("test") != 0)
                {
                    strTwo.Append(words[i]);
                    strTwo.Append(' ', 1);
                }
            }
            
        }
        StreamWriter writeFile = new StreamWriter(@"../../file.txt");
        using (writeFile)
        {
            writeFile.Write(strTwo);
        }
    }
}