/// A dictionary is stored as a sequence of text lines containing words and their explanations.
/// Write a program that enters a word and translates it by using the dictionary. 
/// Sample dictionary:
/// .NET – platform for applications from Microsoft
/// CLR – managed execution environment for .NET
/// namespace – hierarchical organization of classes

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Dictionary
{
    static void Main(string[] args)
    {
        Console.Write("Search for a word: ");
        string inputStr = Console.ReadLine();
        Console.WriteLine("{0} - {1}", inputStr, DictionaryMatch(inputStr));
    }

    private static string DictionaryMatch(string word)
    {
        word = word.Trim();
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        dictionary.Add(".NET", "platform for applications from Microsoft");
        dictionary.Add("CLR", "managed execution environment for .NET");
        dictionary.Add("namespace", "hierarchical organization of classes");

        foreach (var entry in dictionary)
        {
            if (entry.Key.ToLowerInvariant() == word.ToLowerInvariant())
            {
                return entry.Value;
            }
        }

        return "not found";
    }
}