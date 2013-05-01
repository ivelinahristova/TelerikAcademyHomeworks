using System;
using System.Text;

class Brackets
{
    static void Main()
    {
        string str = Console.ReadLine();
        int openBracketsCounter = 0;
        int closeBracketsCounter = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == '(')
            {
                openBracketsCounter++;
            }
            if (str[i] == ')')
            {
                
                closeBracketsCounter++;
                if (openBracketsCounter < closeBracketsCounter)
                {
                    break;
                }
            }
            
        }
        if (openBracketsCounter!=closeBracketsCounter)
        {
            Console.WriteLine("Incorrect brackets!");
        }
        else
        {
            Console.WriteLine("Correct brackets!");
        }
    }
}
