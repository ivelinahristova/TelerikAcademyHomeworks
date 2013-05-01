using System;

class HelloWorld
{
    static void Main()
    {
        string partOne, partTwo, helloWorld;
        object partConnection;
        partOne = "Hello";
        partTwo = "World";
        partConnection = partOne + " " + partTwo;
        helloWorld = (string)partConnection;
        Console.WriteLine(helloWorld);
    }
}
