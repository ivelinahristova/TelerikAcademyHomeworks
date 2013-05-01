using System;
using System.IO;
using System.Text;
class CompareFiles
{
    static void Main()
    {
        StreamWriter writerOne = new StreamWriter(@"..\..\textOne.txt", false, Encoding.GetEncoding("windows-1251"));
        using (writerOne)
        {
            writerOne.WriteLine("Лимоните съдържат повече захар отколкото ягодите.");
            writerOne.WriteLine("Може да накарате крава да се изкачва нагоре по стълби, но не и да слезе.");
            writerOne.WriteLine("Котките прекарват шейсет и шест процента от живота си в сън.");
            writerOne.WriteLine("Жените мигат два пъти по-често от мъжете.");
            writerOne.WriteLine("Хората със сини очи са по-чувствителни на болка от останалите хора.");
        }
        StreamWriter writerTwo = new StreamWriter(@"..\..\textTwo.txt", false, Encoding.GetEncoding("windows-1251"));
        using (writerTwo)
        {
            writerTwo.WriteLine("Костите на човека са съставени 50% от вода.");
            writerTwo.WriteLine("36 800 000 - това са ударите на сърцето на човек за 1 година. ");
            writerTwo.WriteLine("Котките прекарват шейсет и шест процента от живота си в сън.");
            writerTwo.WriteLine("Жените мигат два пъти по-често от мъжете.");
            writerTwo.WriteLine("Удряйки главата си в стена, човек може да изразходва около 150 калории за 1 час.");
        }
        int counter = 0;
        int lineNumber = 0;
        StreamReader reader = new StreamReader(@"..\..\textOne.txt", Encoding.GetEncoding("windows-1251"));
        using (reader)
        {
            
            string lineOne = reader.ReadLine();
            while (lineOne!=null)
            {
                lineNumber++;
                StreamReader readerTwo = new StreamReader(@"..\..\textTwo.txt", Encoding.GetEncoding("windows-1251"));
                using (readerTwo)
                {
                    string line = readerTwo.ReadLine();
                    while (line != null)
                    {
                        if (line.CompareTo(lineOne) == 0)
                        {
                            counter++;
                        }
                        line = readerTwo.ReadLine();
                    }
                }
                lineOne = reader.ReadLine();
            }

        }
        Console.WriteLine("Equal lines:{0}\nNot equal lines:{1}",counter, lineNumber-counter);
    }
}
