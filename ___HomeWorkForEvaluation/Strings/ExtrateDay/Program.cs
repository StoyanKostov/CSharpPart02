using System;
using System.Globalization;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        string text = Console.ReadLine();
        string patern = @"([0-9][0-9].[0-9][0-9].[0-9][0-9][0-9][0-9])";
        Match match = Regex.Match(text, patern);
        while (match.Success)
        {
            string stringDate = match.ToString();
            DateTime date;
            if (DateTime.TryParseExact(stringDate, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            {
                Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat.ShortDatePattern));
            }
            match = match.NextMatch();
        }
    }
}

