/* Write a program that reads a string from the console and lists all different words
 * in the string along with information how many times each word is found. */

using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class CountDifferentWords
{
    static void Main(string[] args)
    {
        Console.Write("Please, enter an string: ");
        string inString = Console.ReadLine();

        //string inString = "Who know what is palindrome? A word like ABBA, lamal, exe, SOS. Also radar, level...";

        Dictionary<string, int> words = new Dictionary<string, int>();

        foreach (Match word in Regex.Matches(inString, @"\w+"))
        {
            if (words.ContainsKey(word.Value))
            {
                words[word.Value]++;
            }
            else
            {
                words.Add(word.Value, 1);
            }
        }

        Console.WriteLine("{0,15} - {1,3}\n","Word", "count");
        foreach (var word in words)
        {
            Console.WriteLine("{0,15} - {1,3}", word.Key, word.Value);
        }
    }
}