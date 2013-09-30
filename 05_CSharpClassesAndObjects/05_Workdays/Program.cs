///Write a method that calculates the number of workdays between today and given date, passed as parameter. 
///Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Workdays
{
    static void Main(string[] args)
    {
        DateTime[] dateHolydays = new DateTime[]
        {
            new DateTime (2013, 08, 08),
            new DateTime (2013, 08, 20),
            new DateTime (2013, 08, 22),
            new DateTime (2013, 08, 27),
            new DateTime (2013, 08, 29),
            new DateTime (2013, 09, 20),
            new DateTime (2013, 09, 22),
            new DateTime (2013, 09, 27),
            new DateTime (2013, 09, 29),
            new DateTime (2013, 10, 20),
            new DateTime (2013, 10, 22),
            new DateTime (2013, 10, 27),
            new DateTime (2013, 10, 29),
            new DateTime (2013, 11, 20),
            new DateTime (2013, 11, 22),
            new DateTime (2013, 11, 27),
            new DateTime (2013, 11, 29),
            new DateTime (2013, 12, 20),
            new DateTime (2013, 12, 22),
            new DateTime (2013, 12, 27),
            new DateTime (2013, 12, 29),
            new DateTime (2013, 12, 20),
            new DateTime (2014, 01, 22),
            new DateTime (2014, 01, 27),
            new DateTime (2014, 01, 29)
        };

        DateTime startDate = DateTime.Today;
        
        // Work days counter
        uint counter = 0; 

        // Console Input
        Console.WriteLine("Give a date to calculate work day from today: ");
        Console.WriteLine("Example:  2008-05-01");
        string inputDate = Console.ReadLine();
        DateTime endDate = DateTime.Parse(inputDate);


        // Main Logic

        // If input date before today exchage values of startDate and endDate
        if (endDate.CompareTo(startDate) < 0)
        {
            DateTime exchangeDates = startDate;
            startDate = endDate;
            endDate = exchangeDates;
        }

        // Incremets start date + 1 day and checks for matchs with weekends and holydays till start date is equal to end date
        while (!startDate.Equals(endDate.AddDays(1)))
        {
            if ((startDate.DayOfWeek != DayOfWeek.Saturday) && (startDate.DayOfWeek != DayOfWeek.Sunday)) //If Not Sunday or Saturday
            {
                if (!dateHolydays.Contains(startDate)) //If Not a holyday
                {
                    counter++;
                    //Console.WriteLine(startDate.DayOfWeek);
                }
            }
            startDate = startDate.AddDays(1); // Increment days
        }

        // Consol output
        Console.WriteLine(counter);
    }
}
