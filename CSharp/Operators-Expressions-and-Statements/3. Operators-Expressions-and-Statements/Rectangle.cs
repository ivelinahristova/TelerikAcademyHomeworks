using System;

class Rectangle
{
    static void Main()
    {
        double height, width;
        Console.Write("Enter rectangle's height:");
        height = double.Parse(Console.ReadLine());
        Console.Write("Enter rectangle's width:");
        width = double.Parse(Console.ReadLine());
        Console.WriteLine(width*height);

    }
}
