using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
class ExtractFromXML
{
    static void Main()
    {
        bool inBrackets = false;
        string str;
        string strTwo;
        StringBuilder part = new StringBuilder();
        StreamReader readFile = new StreamReader(@"../../file.txt");
        using (readFile)
        {
            str = readFile.ReadToEnd();
        }
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == '<')
            {

                while (str[i]!='>')
                {
                    i++;
                }
            }
            else
            {
                part.Append(str[i]);
            }
           

        }
        Console.WriteLine(part.ToString());
        //StreamWriter writeFile = new StreamWriter(@"../../file.txt");
        //using (writeFile)
        //{
        //    writeFile.Write(strTwo);
        //}
    }
}
