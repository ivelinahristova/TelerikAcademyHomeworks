using System;
using System.Text;
class ParseURL
{
    static void Main()
    {
        Console.Write("Enter URL:");
        string url = Console.ReadLine();
        string[] split = url.Split(':');
        int index = -1;
        string protocol = split[0];
        string server;
        string resource;
        for (int i = 2; i < split[1].Length; i++)
        {
            if (split[1][i] == '/')
            {
                index = i;
                break;
            }
        }
        if (index>=0)
        {
            server = split[1].Substring(2, index - 2);
            resource = split[1].Substring(index, split[1].Length - index);
        }
        else
        {
            Console.WriteLine("Incorrect URL!");
            return;
        }
        Console.WriteLine("protocol: {0}", protocol);
        Console.WriteLine("server: {0}", server);
        Console.WriteLine("resource: {0}", resource);
    }
}