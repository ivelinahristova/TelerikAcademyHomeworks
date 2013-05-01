using System;

class ReplaceLinks
{
    static void Main()
    {
        Console.Write("Enter HTML text:");
        string html = Console.ReadLine();
        html = html.Replace("<a href=", "[URL=");
        html = html.Replace("</a>", "[/URL]");
        for (int i = 0; i < html.Length; i++)
        {
            if (html[i] == '[')
            {
                bool flag = false;
                for (int j = i; j < html.Length; j++)
                {
                    
                    if (html[j] == '<')
                    {
                        flag = true;
                    }
                    if (!flag && html[j]=='>')
                    {
                        html = html.Remove(j, 1);
                        html = html.Insert(j, ']'.ToString());
                    }
                }
            }
        }
        Console.WriteLine(html);

    }
}