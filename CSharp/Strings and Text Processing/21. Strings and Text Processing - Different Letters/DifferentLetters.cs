using System.Text;
using System;
class DifferentLetters
{
    static bool IsItThere(StringBuilder letters, char someLetter)
    {
        for (int i = 0; i < letters.Length; i++)
        {
            if (someLetter == letters[i])
            {
                return true;
            }
        }
        return false;
    }
    static void Main()
    {

    }
}
