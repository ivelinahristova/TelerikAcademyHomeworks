using System;

class Point
{
    static void Main()
    {
        double x, y;
            Console.Write("Enter x:");
            x = double.Parse(Console.ReadLine());
            Console.Write("Enter y:");
            y = double.Parse(Console.ReadLine());

            if (((x - 1) * (x - 1) + (y - 1) * (y - 1)) < 9)
            {
                if (y > 1)
                {
                    Console.WriteLine("True");
                }
                else if ((y < 1 || y > -1) && x < -1)
                {
                    Console.WriteLine("True");
                }
                else if (y < -1)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
    }
}
