/* Write a program that extracts from a given text all dates that match
 * the format DD.MM.YYYY. Display them in the standard date format for Canada. */

using System;
using System.Text;
using System.Globalization;
using System.Text.RegularExpressions;

class ExtractAndDisplayDates
{
    static void Main()
    {
        string inString = "List with numbers like 12.53, 16563, also date in format 15.12.2002, 12/12/2014, 2.03.2011 and so on";
        string patern = @"\b\d{1,2}\.\d{1,2}\.\d{4}\b";

        foreach (Match match in Regex.Matches(inString, patern))
        {
            DateTime date;
            if (DateTime.TryParseExact(match.Value ,"d.M.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            {
                Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat.ShortDatePattern));
            }
        }
    }
}