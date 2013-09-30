using System;
using System.Collections.Generic;
using System.Linq;

class LastDigit
{
    /// Write a method that returns the last digit of given integer as an English word. Examples: 512  "two", 1024  "four", 12309  "nine".

    static string LastDigitAsWord(int number)
    {
        int lastDidit = number % 10;
        string result = " ";

        switch (lastDidit)
        {
            case 0:
                result = "Zero";
                break;
            case 1: 
                result = "One";
                break;
            case 2:
                result = "Two";
                break;
            case 3:
                result = "Three";
                break;
            case 4:
                result = "Four";
                break;
            case 5:
                result = "Five";
                break;
            case 6:
                result = "Six";
                break;
            case 7:
                result = "Seven";
                break;
            case 8:
                result = "Eight";
                break;
            case 9:
                result = "Nine";
                break;
        }
        return result;
    }

    static void Main(string[] args)
    {
        // Consol input
        Console.Write("Give number: ");
        int number = int.Parse(Console.ReadLine());

        // Method Call
        string stringOutput = LastDigitAsWord(number);

        // Consol Output
        Console.WriteLine(stringOutput);
    }
}

