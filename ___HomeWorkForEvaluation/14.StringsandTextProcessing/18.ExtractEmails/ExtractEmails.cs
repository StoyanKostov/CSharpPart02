/* Write a program for extracting all email addresses from given text.
 * All substrings that match the format <identifier>@<host>…<domain>
 * should be recognized as emails. */

using System;
using System.Text;
using System.Text.RegularExpressions;

class ExtractEmails
{
    static void Main()
    {
        string inString = "This file should contain some e-mails like gogo@pepi.bg or some_one@123.email.info";
        string patern = @"\w+@\w+(\.\w+)+";

        foreach (Match email in Regex.Matches(inString, patern))
        {
            Console.WriteLine(email.Value);
        }
    }
}