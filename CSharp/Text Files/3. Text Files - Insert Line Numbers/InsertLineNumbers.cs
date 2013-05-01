using System;
using System.IO;
using System.Text;

class InsertLineNumbers
{
    static void Main()
    {
        StreamWriter writer = new StreamWriter(@"..\..\text.txt", false, Encoding.GetEncoding("windows-1251"));
        using (writer)
        {
            writer.WriteLine("Лимоните съдържат повече захар отколкото ягодите.");
            writer.WriteLine("Може да накарате крава да се изкачва нагоре по стълби, но не и да слезе.");
            writer.WriteLine("Котките прекарват шейсет и шест процента от живота си в сън.");
            writer.WriteLine("Жените мигат два пъти по-често от мъжете.");
            writer.WriteLine("Хората със сини очи са по-чувствителни на болка от останалите хора.");
        }
        StreamReader reader = new StreamReader(@"..\..\text.txt", Encoding.GetEncoding("windows-1251"));
        using (reader)
        {
            StreamWriter writerTwo = new StreamWriter(@"..\..\textNew.txt", false, Encoding.GetEncoding("windows-1251"));
            using (writerTwo)
            {
                int lineNumber = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    lineNumber++;
                    writerTwo.WriteLine("{0}: {1}", lineNumber, line);
                    line = reader.ReadLine();
                }
            }
            
        }
    }
}
