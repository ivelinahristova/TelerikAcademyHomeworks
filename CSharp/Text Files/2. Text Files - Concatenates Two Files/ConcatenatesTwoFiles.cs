using System;
using System.Text;
using System.IO;
class ConcatenatesTwoFiles
{
    static void Main()
    {
        StreamWriter writerOne = new StreamWriter(@"..\..\textOne.txt", false, Encoding.GetEncoding("windows-1251"));
        using (writerOne)
        {
            writerOne.WriteLine("Line 1: Лимоните съдържат повече захар отколкото ягодите.");
            writerOne.WriteLine("Line 2: Може да накарате крава да се изкачва нагоре по стълби, но не и да слезе.");
            writerOne.WriteLine("Line 3: Котките прекарват шейсет и шест процента от живота си в сън.");
            writerOne.WriteLine("Line 4: Жените мигат два пъти по-често от мъжете.");
            writerOne.WriteLine("Line 5: Хората със сини очи са по-чувствителни на болка от останалите хора.");
        }
        StreamWriter writerTwo = new StreamWriter(@"..\..\textTwo.txt", false, Encoding.GetEncoding("windows-1251"));
        using (writerTwo)
        {
            writerTwo.WriteLine("Line 1: Лимоните съдържат повече захар отколкото ягодите.");
            writerTwo.WriteLine("Line 2: Може да накарате крава да се изкачва нагоре по стълби, но не и да слезе.");
            writerTwo.WriteLine("Line 3: Котките прекарват шейсет и шест процента от живота си в сън.");
            writerTwo.WriteLine("Line 4: Жените мигат два пъти по-често от мъжете.");
            writerTwo.WriteLine("Line 5: Хората със сини очи са по-чувствителни на болка от останалите хора.");
        }
       
        
        
            StreamWriter writerThree = new StreamWriter(@"..\..\textBoth.txt", false, Encoding.GetEncoding("windows-1251"));
            using (writerThree)
            {
                StreamReader readerOne = new StreamReader(@"..\..\textOne.txt", Encoding.GetEncoding("windows-1251"));
                using (readerOne)
                {
                    string line = readerOne.ReadLine();
                    while (line != null)
                    {
                        writerThree.WriteLine(line);
                        line = readerOne.ReadLine();
                    }
                }
                StreamReader readerTwo = new StreamReader(@"..\..\textTwo.txt", Encoding.GetEncoding("windows-1251"));
                using (readerOne)
                {
                    string line = readerTwo.ReadLine();
                    while (line != null)
                    {
                        writerThree.WriteLine(line);
                        line = readerTwo.ReadLine();
                    }
                }
            }
        
    }
}
