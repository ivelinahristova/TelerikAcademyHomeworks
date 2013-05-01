using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
class ReplaceStartFinish
{
    static void Main()
    {
        string str;
        string strTwo;
        StreamReader readFile = new StreamReader(@"../../file.txt");
        using (readFile)
        {
            str = readFile.ReadToEnd();
        }
        strTwo = str.Replace("start", "finish");
        StreamWriter writeFile = new StreamWriter(@"../../file.txt");
        using (writeFile)
        {
            writeFile.Write(strTwo);
        }
    }
}
