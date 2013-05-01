using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;

class HowMuchTimes
{
    static void Main(string[] args)
    {

        Dictionary<string, int> Dictionary = new Dictionary<string, int>();

        using (StreamReader Reader = new StreamReader("../../file.txt"))
        {
            for (string line; (line = Reader.ReadLine()) != null; )
            {
                Dictionary.Add(line, 0);
            }

        }

        using (StreamReader Reader = new StreamReader("../../test.txt"))
        {
            for (string line; (line = Reader.ReadLine()) != null; )
            {
                string[] Content = Regex.Split(line, @"\W+").ToArray<string>();
                foreach (string item in Content)
                {
                    int Value = int.MinValue;

                    if (Dictionary.TryGetValue(item, out Value))
                    {
                        Dictionary[item] = Value + 1;
                    }
                }

            }
        }

        using (StreamWriter Write = new StreamWriter("../../result.txt"))
        {
 
            var Items = from pair in Dictionary orderby pair.Value ascending select pair;
            foreach (KeyValuePair<string, int> pair in Items)
            {
                Console.WriteLine("{0} - {1}", pair.Value, pair.Key);
                Write.WriteLine(pair.Value + " - " + pair.Key);
            }
        }
    }
}