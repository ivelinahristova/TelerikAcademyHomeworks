using System;
using System.IO;
using System.Text;
class OddLines
{
    static void Main()
    {
        StreamWriter writer = new StreamWriter(@"..\..\text.txt",false,Encoding.GetEncoding("windows-1251"));
        using(writer)
        {
            writer.WriteLine("Line 1: Лимоните съдържат повече захар отколкото ягодите.");
            writer.WriteLine("Line 2: Може да накарате крава да се изкачва нагоре по стълби, но не и да слезе.");
            writer.WriteLine("Line 3: Котките прекарват шейсет и шест процента от живота си в сън.");
            writer.WriteLine("Line 4: Жените мигат два пъти по-често от мъжете.");
            writer.WriteLine("Line 5: Хората със сини очи са по-чувствителни на болка от останалите хора.");
        }
        StreamReader reader = new StreamReader(@"..\..\text.txt",Encoding.GetEncoding("windows-1251"));
        using (reader)
        {
            int lineNumber = 0;
            string line = reader.ReadLine();
            while (line!=null)
            {
                lineNumber++;
                if (lineNumber%2!=0)
                {
                    Console.WriteLine(line);
                }
                line = reader.ReadLine();
            }
        }
    }
}
