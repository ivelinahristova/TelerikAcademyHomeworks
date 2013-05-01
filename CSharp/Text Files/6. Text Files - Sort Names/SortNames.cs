using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
class SortNames
{
    static void Main()
    {
        string str;
        StreamReader readFile = new StreamReader(@"../../file.txt");
        using (readFile)
        {
             str = readFile.ReadToEnd();
        }
        
        string[] names = str.Split('\n');
        List<string> name = new List<string>();
        foreach (var item in names)
        {
            name.Add(item);
        }
        name.Sort();
        StreamWriter writeFile = new StreamWriter(@"../../fileSort.txt");
        using (writeFile)
        {
            foreach (var item in name)
            {
                writeFile.WriteLine(item);
            }
        }
    }
}
