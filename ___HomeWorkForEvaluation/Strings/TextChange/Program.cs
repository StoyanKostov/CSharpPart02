using System;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter text with <upcase> tags to transform it to Uppercase:");
        string text = Console.ReadLine();
        string result = Regex.Replace(text, "<upcase>(.*?)</upcase>", c => c.Groups[1].Value.ToUpper());
        Console.WriteLine(result);
    }
}

