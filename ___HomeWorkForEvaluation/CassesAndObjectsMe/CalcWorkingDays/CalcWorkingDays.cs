using System;
using System.Collections.Generic;

class CalcWorkingDays
{
    private static void SwapYears(ref DateTime startDay, ref DateTime endDate)
    {
        DateTime tmpDate = startDay;
        startDay = endDate;
        endDate = tmpDate;
    }


    private static int RomoveHolydaysAndWeekends(DateTime startDay, DateTime endDate)
    {
        List<DateTime> holydays = new List<DateTime>();
        holydays.Add(DateTime.Parse("01.01"));  //MM.dd
        holydays.Add(DateTime.Parse("12.24"));
        holydays.Add(DateTime.Parse("12.25"));
        holydays.Add(DateTime.Parse("12.26"));
        holydays.Add(DateTime.Parse("03.03"));
        holydays.Add(DateTime.Parse("05.01"));
        holydays.Add(DateTime.Parse("05.06"));
        holydays.Add(DateTime.Parse("09.06"));
        holydays.Add(DateTime.Parse("09.22"));
        holydays.Add(DateTime.Parse("03.03"));

        int allDays = (endDate - startDay).Days;

        for (DateTime i = startDay; i < endDate; i = i.AddDays(1))
        {
            if ((i.DayOfWeek == DayOfWeek.Saturday) || (i.DayOfWeek == DayOfWeek.Sunday)) // remove weekends
            {
                allDays--;
            }
            for (int h = 0; h < holydays.Count; h++)    //remove holydays
            {
                if (i.DayOfYear == holydays[h].DayOfYear)
                {
                    allDays--;
                }
            }
        }

        return allDays;
    }

    static void Main()
    {
        DateTime startDay = DateTime.Today;

        Console.Write("This program will calculate the working days from today to given date.\n\nEnter a date in format dd.MM.yyyy: ");
        DateTime endDate = DateTime.Parse(Console.ReadLine());
        //DateTime endDate = DateTime.Parse("27.08.2015");

        if (startDay > endDate)
        {
            SwapYears(ref startDay, ref endDate);
        }

        int allDays = RomoveHolydaysAndWeekends(startDay, endDate);

        Console.WriteLine(
            "\nAll working days between {0} and {1} are {2}.", startDay.ToShortDateString(), endDate.ToShortDateString(), allDays);
    }
}