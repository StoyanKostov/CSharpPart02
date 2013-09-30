/// We are given a string containing a list of forbidden words and a text containing some of these words.
/// Write a program that replaces the forbidden words with asterisks.
/// Words: "PHP, CLR, Microsoft"

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReplaceForbiddenWords
{
    static void Main(string[] args)
    {
        // Console input
        Console.Write("Enter some text: ");
        string inputStr = Console.ReadLine();
        //string inputStr = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";

        Console.Write("Enter the forbidden words separated by space: ");
        string inputWords = Console.ReadLine();
        string[] forbiddenWords = inputWords.Split(' ');
        //string[] forbiddenWords = "PHP CLR Microsoft".Split(' ');

        // Main Logic
        foreach (var word in forbiddenWords)
        {
            inputStr = wordReplaceWithAsterisks(word, inputStr);
        }

        //Consol Output
        Console.WriteLine(inputStr);

    }
    public static string wordReplaceWithAsterisks(string word, string inputString)
    {
        string wordReplace = new string('*', word.Length);
        return inputString.Replace(word, wordReplace);
    }
}