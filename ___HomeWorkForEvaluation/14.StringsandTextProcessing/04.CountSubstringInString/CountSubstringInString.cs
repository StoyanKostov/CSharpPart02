/* Write a program that finds how many times a substring is contained in a given text
 * (perform case insensitive search). */


using System;
using System.Text;
using System.Text.RegularExpressions;

class CountSubstringInString
{
    static void Main()
    {
        string inString = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string substring = "in";

        int count = Regex.Matches(inString, substring, RegexOptions.IgnoreCase).Count;

        Console.WriteLine("Substring '{0}' found {1} times in the string", substring, count);
    }
}
