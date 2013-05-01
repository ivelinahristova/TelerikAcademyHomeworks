using System;
using System.Text;

class ReverseAWord
{
    static void Main()
    {
        string word;
        Console.Write("Enter a word to reverse:");
        word = Console.ReadLine();
        StringBuilder reversedWord = new StringBuilder();
        for (int i = word.Length - 1; i >= 0; i--)
        {
            reversedWord.Append(word[i]);
        }
        Console.WriteLine(reversedWord);
    }
}