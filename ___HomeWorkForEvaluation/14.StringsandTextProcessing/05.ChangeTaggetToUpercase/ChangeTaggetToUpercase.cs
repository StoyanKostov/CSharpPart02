/* You are given a text. Write a program that changes the text in all regions surrounded
 * by the tags <upcase> and </upcase> to uppercase. The tags cannot be nested. */

using System;
using System.Text;
using System.Text.RegularExpressions;

class ChangeTaggetToUpercase
{
    static void Main()
    {
        string inString = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        string upCasePattern = @"<\s*upcase\s*>(?<toUp>.*?)<\s*/upcase\s*>";
        string newString = Regex.Replace(inString, upCasePattern, toUpper => toUpper.Groups["toUp"].Value.ToUpper());
        //string newString = Regex.Replace(inString, upCasePattern, new MatchEvaluator(ToUpper));
        Console.WriteLine(newString);
    }

    //static string ToUpper(Match aMatch)
    //{
    //    return aMatch.Groups["toUp"].Value.ToUpper();
    //}
}