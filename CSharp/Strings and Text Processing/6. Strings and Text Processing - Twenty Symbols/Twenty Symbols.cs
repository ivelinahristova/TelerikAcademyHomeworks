
// Firtstly I made the commented code but it didn't work [I have no idea why]
using System;
using System.Text;

class TwentySymbols
{
    static void Main()
    {


        //StringBuilder text = new StringBuilder();
        //ConsoleKeyInfo key;
        //do
        //{
        //    key = Console.ReadKey();
        //    text.Append(key.KeyChar);
        //} while (key.KeyChar != (char)13 && text.Length<20);
        //Console.WriteLine();

        //text.Append('*',20-text.Length);



        Console.WriteLine("Enter text[max 20 symbols]");
        string str = Console.ReadLine();
        Console.WriteLine(str.PadRight(20, '*'));

    }
}
