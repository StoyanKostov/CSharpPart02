///Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.

using System;
using System.Collections.Generic;

class LeapYear
{
    static void Main(string[] args)
    {
        // Console Input
        Console.Write("Check For Leap Year: ");
        int inputYear = int.Parse(Console.ReadLine()); // Microsof reference: year is specified as a 4-digit base 10 number; for example, 1996.

        // Main Logic
        bool isLeap = DateTime.IsLeapYear(inputYear);

        // Consol Output
        Console.WriteLine("Entered year is a leap: {0}", isLeap);
    }
}

