using System;
using System.Text;

class Palindromes
{
    static bool Palindrome(string word)
    {
        StringBuilder reversedWord = new StringBuilder();
        for (int i = word.Length - 1; i >= 0; i--)
        {
            reversedWord.Append(word[i]);
        }
        if (reversedWord.ToString() == word)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static void Main()
    {
        Console.Write("Enter text to check for palindromes: ");
        string str = Console.ReadLine();
        string[] words = str.Split(' ', '.', ',', '!', '?', ';', ':');
        for (int i = 0; i < words.Length; i++)
        {
            if (Palindrome(words[i]))
            {
                Console.WriteLine(words[i]);
            }
        }
    }
}
