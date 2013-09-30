/// Write a program that extracts from a given text all sentences containing given word.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

class SentencesContainingGivenWord
{
    static void Main(string[] args)
    {
        // Console input
        Console.Write("Enter some text: ");
        //string inputStr = Console.ReadLine();
        string inputStr = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";

        Console.Write("Enter the word to search sentenses with: ");
        string inputWord = Console.ReadLine();

        // Main Logic
        string[] sentenses = inputStr.TrimEnd('.').Split('.');

        foreach (var sentense in sentenses)
        {
            if (Regex.IsMatch(sentense, "\\b" + inputWord + "\\b"))
            {
                Console.WriteLine(sentense.Trim(' '));
            }
        }
    }
}
