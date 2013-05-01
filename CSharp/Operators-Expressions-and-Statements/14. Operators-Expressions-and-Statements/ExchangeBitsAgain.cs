using System;

class ExchangeBitsAgain
{
    static void Main()
    {
        uint number, mask = 1, bitOne, bitTwo, num;
        byte p, q, k;
        byte distance;
        Console.Write("Enter number:");
        number = uint.Parse(Console.ReadLine());
        Console.Write("Enter p:");
        p = byte.Parse(Console.ReadLine());
        Console.Write("Enter q:");
        q = byte.Parse(Console.ReadLine());
        Console.Write("Enter k:");
        k = byte.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        distance = Convert.ToByte(q-p);
        for (byte i = p; i <= k; i++)
        {
            mask = mask << i;
            bitOne = (mask & number) >> i;
            mask = mask >> i;
            mask = mask << i+distance;
            bitTwo = (mask & number) >> i + distance;
            mask = mask >> i + distance;
            if (bitOne != bitTwo)
            {
                if (bitOne == 1)
                {
                    num = number | (mask << i + distance);
                    number = num ^ (mask << i);
                }
                else
                {
                    num = number ^ (mask << i + distance);
                    number = num | (mask << i);
                }
            }
        }
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}
