using System;
using System.Text;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        var strBuilder = new StringBuilder(input);
        strBuilder.Replace("<a href=\"", "[URL=");
        strBuilder.Replace("</a>", "[/URL]");
        strBuilder.Replace("\">", "]");
        Console.WriteLine(strBuilder.ToString());
    }
}

