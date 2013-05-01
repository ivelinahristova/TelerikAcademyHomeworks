using System;
   
class floatingPointNumbers
    {
        static void Main()
        {
            bool isTrue;
            decimal numberOne, numberTwo;
            Console.Write("Number One=");
            numberOne = Decimal.Parse(Console.ReadLine());
            Console.Write("Number Two=");
            numberTwo = Decimal.Parse(Console.ReadLine());
            if (Math.Abs(numberOne-numberTwo)<0.000001M) isTrue = true;
            else isTrue = false;
            Console.WriteLine(isTrue);

        }
    }

