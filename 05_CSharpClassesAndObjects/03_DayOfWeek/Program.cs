///Write a program that prints to the console which day of the week is today. Use System.DateTime.

using System;
using System.Collections.Generic;

class DayOfWeek
{
    static void Main(string[] args)
    {
        DateTime currentDay = DateTime.Now;

        // Consol output
        Console.WriteLine(currentDay.DayOfWeek);
    }
}
