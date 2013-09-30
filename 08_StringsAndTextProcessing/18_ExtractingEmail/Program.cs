/// Write a program for extracting all email addresses from given text. 
/// All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

class ExtractingEmail
{
    static void Main(string[] args)
    {
        string inputText = "Please contact us by phone (+359 222 222 222) or by email at example@abv.bg or at baj.ivan@yahoo.co.uk. This is not email: test@test. This also: @telerik.com. Neither this: a@a.b.";

        Regex email = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", RegexOptions.IgnoreCase);
        MatchCollection emails = email.Matches(inputText);

        foreach (Match match in emails)
        {
            Console.WriteLine(match.Value);
        }
    }
}