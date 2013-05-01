using System;
class Dictionary
{
    static void Main()
    {
        string[] dictionary = { ".NET - platform for applications from Microsoft",
                                "CLR - managed execution environment for .NET",
                                "namespace - hierarchical - organization of classes"};
        Console.Write("Enter word:");
        string word = Console.ReadLine();
        foreach (string line in dictionary)
        {
            if (line.IndexOf(word + " -") == 0)
            {
                Console.WriteLine(line);
            }
        }
    }
}