using System;
using System.Text;

class ReverseSentence
{
    static void Main()
    {
        Console.Write("Enter a sentence:");
        string sentence = Console.ReadLine();
        string[] words = sentence.Split(' ', '!', ',', '?', '.');
        StringBuilder newSentence = new StringBuilder();
        for (int i = words.Length-1; i >= 0; i--)
        {
            newSentence.Append(words[i] + " ");
        }
        Console.WriteLine(newSentence);
    }
}
