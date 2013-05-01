using System;
using System.Text;
class asciiSymbol
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        char symbol;
        for (int i = 0; i < 128; i++)
        {
            switch (i)
            {
                case 0: Console.WriteLine("{0}\tControl\t\tNull Char", i); break;
                case 1: Console.WriteLine("{0}\tControl\t\tStart of Heading", i); break;
                case 2: Console.WriteLine("{0}\tControl\t\tStart of Text", i); break;
                case 3: Console.WriteLine("{0}\tControl\t\tEnd of Text", i); break;
                case 4: Console.WriteLine("{0}\tControl\t\tEnd of Transmission", i); break;
                case 5: Console.WriteLine("{0}\tControl\t\tEnquiry", i); break;
                case 6: Console.WriteLine("{0}\tControl\t\tAcknowledgment", i); break;
                case 7: Console.WriteLine("{0}\tControl\t\tBell", i); break;
                case 8: Console.WriteLine("{0}\tControl\t\tBack Space", i); break;
                case 9: Console.WriteLine("{0}\tControl\t\ttab.",i); break;
                case 10: Console.WriteLine("{0}\tControl\t\tnew line",i); break;
                case 11: Console.WriteLine("{0}\tControl\t\tvertical-tab",i); break;
                case 12: Console.WriteLine("{0}\tControl\t\tform-feed (next page)",i); break;
                case 13: Console.WriteLine("{0}\tControl\t\tcarriage-return",i); break;
                case 14: Console.WriteLine("{0}\tControl\t\tShift Out / X-On", i); break;
                case 15: Console.WriteLine("{0}\tControl\t\tShift In / X-Off", i); break;
                case 16: Console.WriteLine("{0}\tControl\t\tData Line Escape", i); break;
                case 17: Console.WriteLine("{0}\tControl\t\tDevice Control 1 (oft. XON)", i); break;
                case 18: Console.WriteLine("{0}\tControl\t\tDevice Control 2", i); break;
                case 19: Console.WriteLine("{0}\tControl\t\tDevice Control 3 (oft. XOFF)", i); break;
                case 20: Console.WriteLine("{0}\tControl\t\tDevice Control 4", i); break;
                case 21: Console.WriteLine("{0}\tControl\t\tNegative Acknowledgement", i); break;
                case 22: Console.WriteLine("{0}\tControl\t\tSynchronous Idle", i); break;
                case 23: Console.WriteLine("{0}\tControl\t\tEnd of Transmit Block", i); break;
                case 24: Console.WriteLine("{0}\tControl\t\tCancel", i); break;
                case 25: Console.WriteLine("{0}\tControl\t\tEnd of Medium", i); break;
                case 26: Console.WriteLine("{0}\tControl\t\tSubstitute", i); break;
                case 27: Console.WriteLine("{0}\tControl\t\tEscape", i); break;
                case 28: Console.WriteLine("{0}\tControl\t\tFile Separator", i); break;
                case 29: Console.WriteLine("{0}\tControl\t\tGroup Separator", i); break;
                case 30: Console.WriteLine("{0}\tControl\t\tRecord Separator", i); break;
                case 31: Console.WriteLine("{0}\tControl\t\tUnit Separator", i); break;
                case 32: Console.WriteLine("{0}\t\t\tSpace", i); break;
                default:


                    symbol = (char)i;
                    Console.WriteLine("{0}\t\t\t{1}", i, symbol); break;
            }
        }
    }
}