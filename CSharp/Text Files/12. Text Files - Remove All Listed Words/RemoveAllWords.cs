using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class RemoveAllWords
{
    static void Main()
    {
        string text1 = @"..\..\dictionary.txt";
        string text2 = @"..\..\text.txt";
        string tempFile = Path.GetTempFileName();
        List<string> wordsList = new List<string>();
        try
        {
            StreamReader readDictionary = new StreamReader(text1);
            StreamReader readText = new StreamReader(text2);
            using (readDictionary)
            {
                string line;
                while ((line = readDictionary.ReadLine()) != null)
                {
                    string[] words = line.Split(' ');
                    foreach (var word in words)
                    {
                        wordsList.Add(word);
                    }
                }
                using (readText)
                {
                    using (var writer = new StreamWriter(tempFile))
                    {
                        string currentLine;
                        while ((currentLine = readText.ReadLine()) != null)
                        {
                            foreach (var word in wordsList)
                            {
                                currentLine = Regex.Replace(currentLine, @"\b" + word + @"\b", "");
                            }
                            writer.WriteLine(currentLine);
                        }
                    }
                }
            }
            File.Delete(text2);
            File.Move(tempFile, text2);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found!");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Invalid path.");
        }
        catch (IOException fe)
        {
            Console.WriteLine(fe.Message);
        }
    }
}