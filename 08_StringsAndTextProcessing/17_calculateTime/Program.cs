/// Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints the date and time after 6 hours and 30 minutes (in the same format)
/// along with the day of week in Bulgarian.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

class CalculateTime
{

    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        DateTime currentDate = DateTime.Now;

        DateTime date = currentDate.AddHours(6.5);
        
        Console.WriteLine("{0} {1}", date.ToString("dddd", new CultureInfo("bg-BG")), date);
    }
}