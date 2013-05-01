using System;

class IsInCircle
{
    static void Main()
    {
        double x, y;
        Console.Write("enter x:");
        x = double.Parse(Console.ReadLine());
        Console.Write("enter y:");
        y = double.Parse(Console.ReadLine());
        if (x <= 5 && y <= 5)
        {
            Console.WriteLine("Point ({0},{1}) is in the circle", x, y);
        }
        else Console.WriteLine("Point ({0},{1}) isn't in the circle", x, y);

    }
}
