/* Write a program that extracts from given HTML file its title (if available),
 * and its body text without the HTML tags. */

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class ExtractFromHTML
{
    static void Main()
    {
        string inputFile = "..\\..\\HTMLFile.txt";

        StreamReader reader = new StreamReader(inputFile);
        string text;

        using (reader)
        {
            text = reader.ReadToEnd();
        }
        string urlPattern = @">(.*?)<";

        List<string> list = new List<string>();

        foreach (Match word in Regex.Matches(text, urlPattern))
        {
            if (!String.IsNullOrEmpty(word.Groups[1].Value))
            {
                list.Add(word.Groups[1].Value);
            }
        }

        foreach (string item in list)
        {
            Console.WriteLine(item);
        }
    }
}