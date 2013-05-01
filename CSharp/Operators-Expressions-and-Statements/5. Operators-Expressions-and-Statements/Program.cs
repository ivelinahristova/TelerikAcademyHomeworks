using System;

class BitwiseOperators
{
    static void Main()
    {
        int number,mask=1;
        bool bit;
        number = int.Parse(Console.ReadLine());
        bit =((mask << 4 & number)!=0 ? true : false);
        Console.WriteLine("Statement \"Third bit of {0} is 1\" is {1}",number,bit);
    }
}