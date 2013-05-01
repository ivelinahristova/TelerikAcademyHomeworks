using System;

class ExchangeBits
{
    static void Main()
    {
        uint number,mask = 1,bitOne,bitTwo,num;
        byte k = 3,p = 24;
        Console.Write("Enter number:");
        number = uint.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        for (byte i = 1; i <= 3; i++, k++, p++)
        {
            mask = mask << k;
            bitOne = (mask & number) >> k;
            mask = mask >> k;
            mask = mask << p;
            bitTwo = (mask & number) >> p;
            mask = mask >> p;
            if (bitOne != bitTwo)
            {
                if (bitOne == 1)
                {
                    num = number | (mask << p);
                    number = num ^ (mask << k);
                }
                else
                {
                    num = number ^ (mask << p);
                    number = num | (mask << k);
                }
            }
        }
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}
