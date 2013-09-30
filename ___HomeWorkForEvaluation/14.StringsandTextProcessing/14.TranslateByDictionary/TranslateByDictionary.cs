/* A dictionary is stored as a sequence of text lines containing words and their explanations.
 * Write a program that enters a word and translates it by using the dictionary. */

using System;
using System.Text;
using System.Text.RegularExpressions;



class TranslateByDictionary
{
    static void Main()
    {
        string[] dictionary ={ ".NET – platform for applications from Microsoft",
                            "CLR – managed execution environment for .NET", 
                            "namespace – hierarchical organization of classes"};

        string regex = @"(.+?)\b\s+?–\s+?(\b.*)";

        string searched = "namespace";

        foreach (var item in dictionary)
        {
            Match keyWord = Regex.Match(item, regex);
            if (keyWord.Groups[1].Value == searched)
            {
                Console.WriteLine(keyWord.Groups[1].Value + " - " + keyWord.Groups[2].Value);
            }
        }
    }
}