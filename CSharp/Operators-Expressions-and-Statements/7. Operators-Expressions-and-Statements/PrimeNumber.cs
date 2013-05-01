using System;

class PrimeNumber
{
    static void Main()
    {
        int number;
        byte count=0;
        do
        {
            Console.Write("Enter positive number:");
            number = int.Parse(Console.ReadLine());
        } while (number<=0 || number>100);
        for (int i = 1; i <= number; i++)
        {
            if (number%i==0)
            {
                count++; if (count>=3)
                {
                    break;
                }
            }
        }
        if (count==2)
        {
            Console.WriteLine("{0} is Prime",number);
        }
        else Console.WriteLine("{0} isn't Prime",number);
    }
}
