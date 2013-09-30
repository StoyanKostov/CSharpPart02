/* Write a program that extracts from a given text all palindromes,
 * e.g. "ABBA", "lamal", "exe". */

using System;
using System.Text;
using System.Text.RegularExpressions;

class ExtractPalindromes
{
    static void Main()
    {
        string inString = "Who know what is palindrome? A word like ABBA, lamal, exe, SOS. Also radar, level...";

        foreach (Match word in Regex.Matches(inString, @"\w{3,}"))
        {
            if (isPalindrome(word.Value))
            {
                Console.WriteLine(word.Value);
            }
        }
    }

    static bool isPalindrome(string word)
    {
        for (int i = 0; i < word.Length / 2; i++)
        {
            if (word[i] != word[word.Length - i - 1])
            {
                return false;
            }
        }
        return true;
    }
}