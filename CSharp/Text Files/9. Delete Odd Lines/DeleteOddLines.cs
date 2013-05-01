using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
class DeleteOddLines
{
    static void Main()
    {
        StreamReader readFile = new StreamReader(@"../../file.txt");
        List<string> lines = new List<string>();
        using (readFile)
        {
            while (readFile.ReadLine() !=null)
            {
                lines.Add(readFile.ReadLine());
            }
           
        }
        for (int i = 0; i < lines.Count; i++)
        {
            if (i%2!=0)
            {
                lines.Remove(lines[i]);
            }
            
        }
        
        StreamWriter writeFile = new StreamWriter(@"../../file.txt");
        using (writeFile)
        {
            for (int i = 0; i < lines.Count; i++)
            {
                writeFile.WriteLine(lines[i]);
            }
        }
    }
}
