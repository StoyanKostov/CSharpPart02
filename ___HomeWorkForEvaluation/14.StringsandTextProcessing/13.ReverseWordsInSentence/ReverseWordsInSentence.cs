/* Write a program that reverses the words in given sentence.
 * Example: "C# is not C++, not PHP and not Delphi!"  "Delphi not and PHP, not C++ not is C#!". */

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

class ReverseWordsInSentence
{
    static void Main()
    {
        string input = "C# is not C++, not PHP and not Delphi.";
        string separators = @"\s+|,\s*|\.\s*|!\s*|;\s*|:\s*";

        var words = new Stack<string>();

        foreach (var word in Regex.Split(input, separators))
        {
            if (!String.IsNullOrEmpty(word))
            {
                words.Push(word);
            }
        }

        StringBuilder sb = new StringBuilder();

        foreach (var separator in Regex.Matches(input, separators))
        {
            sb.Append(words.Pop() + separator);
        }
        string result = sb.ToString();

        Console.WriteLine(result);
    }
}