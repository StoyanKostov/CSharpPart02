/* Write a program that reads a string from the console and replaces all series of consecutive
 * identical letters with a single one. Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa". */

using System;
using System.Text;

class ReplaceSeriesOfLetters
{
    static void Main()
    {
        //string inString = "aaaaabbbbbcdddeeeedssaa";

        Console.Write("Please, enter an string: ");
        string inString = Console.ReadLine();

        if (inString.Length < 2)
        {
            Console.WriteLine("The string is too short!");
            return;
        }

        char oldLetter = inString[0];
        StringBuilder sb = new StringBuilder();
        sb.Append(inString[0]);

        for (int i = 1; i < inString.Length; i++)
        {
            if (inString[i] != oldLetter)
            {
                sb.Append(inString[i]);
                oldLetter = inString[i];
            }
        }
        Console.WriteLine(sb);
    }
}