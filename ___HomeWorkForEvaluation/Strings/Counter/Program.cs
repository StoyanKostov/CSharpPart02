using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter substring to search for:");
        string searchedSubstring = Console.ReadLine().ToLower();
        Console.WriteLine("Now enter some text to search for the substring:");

        string text = " " + Console.ReadLine().ToLower();
        int index = 0;
        int countedSubstrings = 0;

        while (true)
        {

            index = text.IndexOf(searchedSubstring, index + 1);
            if (index == -1)
            {
                break;
            }
            countedSubstrings++;

        }
        Console.WriteLine(countedSubstrings);
    }
}
