/// Write a program that reads an integer number and calculates and prints its square root. 
/// If the number is invalid or negative, print "Invalid number". 
/// In all cases finally print "Good bye". Use try-catch-finally.
using System;
using System.Collections.Generic;

class Root
{
    public static double SquareRoot(double value)
    {
        if (value < 0)
        {
            throw new ArgumentOutOfRangeException();
        }
        return Math.Round(Math.Sqrt(value), 2);
    }

    static void Main(string[] args)
    {
        // Consol Input
        Console.Write("Input number to find its square root: ");
        string input = Console.ReadLine();

        // Main logic
        try
        {
            double number = double.Parse(input);
            double squareRoot = SquareRoot(number);
            Console.WriteLine("Square root of {0} is {1}", number, squareRoot);
        }
        catch (Exception)
        {
            Console.Error.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine("So Long, and Thanks for All the Fish");
        }
    }
}

