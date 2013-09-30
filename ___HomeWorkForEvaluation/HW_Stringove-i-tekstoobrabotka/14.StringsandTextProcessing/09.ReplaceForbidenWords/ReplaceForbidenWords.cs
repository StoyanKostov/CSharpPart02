/* We are given a string containing a list of forbidden words and a text containing some
 * of these words. Write a program that replaces the forbidden words with asterisks. */

using System;
using System.Text;
using System.Text.RegularExpressions;

class ReplaceForbidenWords
{
    static void Main()
    {
        string inString = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        string words = "PHP, CLR, Microsoft";
        string regex = CreateWordList(words);
        string result = Regex.Replace(inString, regex, forbiden => new string('*', forbiden.Length));
        Console.WriteLine(result);
    }

    private static string CreateWordList(string words)
    {
        char[] separators = new char[] { ' ', '/', '\\', '.', ',', ';', ':', '\t', '\n', '\r' };
        string list;
        list = String.Format(@"\b({0})\b", String.Join("|", words.Split(separators, StringSplitOptions.RemoveEmptyEntries)));
        return list;
    }
}