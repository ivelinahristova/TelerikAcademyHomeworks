using System;

class trapeziodArea
{
    static void Main()
    {
        double a, b, h;
        Console.WriteLine("Enter side a:");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter side b:");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter h:");
        h = double.Parse(Console.ReadLine());
        Console.WriteLine("The area of your trapezoid is {0}",(a+b)*h/2);
    }
}
