/* Write a program that reads two dates in the format: day.month.year
 * and calculates the number of days between them. Example:
 * Enter the first date: 27.02.2006
 * Enter the second date: 3.03.2004
 * Distance: 4 days */

using System;
using System.Globalization;
using System.Text;

class CalculateDaysBetweenDates
{
    static void Main()
    {
        Console.WriteLine("Please, enter dates in format day.month.year");
        Console.Write("Enter the first date: ");
        string firstDate = Console.ReadLine();
        Console.Write("Enter the second date: ");
        string secondDate = Console.ReadLine();

        DateTime start = DateTime.ParseExact(firstDate, "d.MM.yyyy", CultureInfo.InvariantCulture);
        DateTime end = DateTime.ParseExact(secondDate, "d.MM.yyyy", CultureInfo.InvariantCulture);
        Console.WriteLine("The distance between {0:d.MM.yyyy} and {1:d.MM.yyyy} is {2} days",
            start, end, (end - start).Days);
    }
}