/* Write a program that reads a list of words, separated by spaces
 * and prints the list in an alphabetical order. */

using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class SortWordsList
{
    static void Main()
    {
        string inString = "Безплатният курс C# програмиране - част II е продължение на навлизането в основите на програмирането.";

        List<string> list = new List<string>();

        foreach (Match word in Regex.Matches(inString, @"\w+"))
        {
            list.Add(word.Value);
        }

        list.Sort();

        foreach (string item in list)
        {
            Console.WriteLine(item);
        }
    }
}