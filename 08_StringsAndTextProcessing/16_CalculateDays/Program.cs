/// Write a program that reads two dates in the format: day.month.year and calculates the number of days between them. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

class CalculateDays
{
    static void Main(string[] args)
    {
        string start = "27.02.2006";
        string end = "3.03.2006";

        DateTime startDate = DateTime.ParseExact(start, "d.MM.yyyy", CultureInfo.InvariantCulture);
        DateTime endDate = DateTime.ParseExact(end, "d.MM.yyyy", CultureInfo.InvariantCulture);

        Console.WriteLine("Interval between {0} and {1} is {2} days.", startDate, endDate, (endDate - startDate).TotalDays);
    }
}