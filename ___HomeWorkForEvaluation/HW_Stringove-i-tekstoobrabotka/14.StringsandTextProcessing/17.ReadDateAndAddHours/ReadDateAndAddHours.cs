/* Write a program that reads a date and time given in the format:
 * day.month.year hour:minute:second and prints the date and time after 6 hours and 30 minutes
 * (in the same format) along with the day of week in Bulgarian. */

using System;
using System.Globalization;
using System.Text;

class ReadDateAndAddHours
{
    static void Main()
    {
        //Console.Write("Enter the date and time in format 'day.month.year hour:minute:second': ");
        //string inDate = Console.ReadLine();
        string inDate = "31.12.2013 19:18:34";

        DateTime date = DateTime.ParseExact(inDate, "d.MM.yyyy H:m:s", CultureInfo.InvariantCulture);
        TimeSpan difference = new TimeSpan(6, 30, 0);
        DateTime newDate = date + difference;
        Console.WriteLine("The time after 6 hours and 30 minutes will be {0:d.MM.yyyy HH:mm:ss}", newDate);
        Console.WriteLine("The day of week in Bulgarian is {0}", newDate.ToString("dddd", new CultureInfo("bg-BG")));
    }
}