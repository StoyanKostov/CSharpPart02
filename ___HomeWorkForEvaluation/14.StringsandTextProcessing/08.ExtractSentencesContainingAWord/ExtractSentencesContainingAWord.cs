// Write a program that extracts from a given text all sentences containing given word.
// Consider that the sentences are separated by "." and the words – by non-letter symbols.

using System;
using System.Text;
using System.Text.RegularExpressions;


class ExtractSentencesContainingAWord
{
    static void Main()
    {
        string inString = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string keyWord = "in";
        string pattern = @"\s*([^\.]*\b" + keyWord + @"\b.*?\.)";
        foreach (Match sentence in Regex.Matches(inString, pattern))
        {
            Console.WriteLine(sentence.Groups[1]);
        }
    }
}