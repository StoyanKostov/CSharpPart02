/// Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. 
/// If an invalid number or non-number text is entered, the method should throw an exception. 
/// Using this method write a program that enters 10 numbers:	a1, a2, … a10, such that 1 < a1 < … < a10 < 100

using System;
using System.Collections.Generic;

class IntegerRange
{
    static void ReadNumber(int value, int start = 1, int end = 100)
    {
        if ( (value < start) || (value > end) )
        {
            throw new ArgumentOutOfRangeException(
                "Input number is out of range!");
        }
    }

    static void Main(string[] args)
    {
        
        int start = 1;

        for (int i = 0; i < 10; i++)
        {
            // Consol Input
            Console.Write("Input a number: ");
            string input = Console.ReadLine();

            // Main logic
            try
            {
                int number = int.Parse(input);
                ReadNumber(number, start); // Calls method
                Console.WriteLine("{0} is in range!", number);
                start = number; // Changes the range
            }
            catch (ArgumentOutOfRangeException ex) //If out of range. Default: 1 - 100 
            {
                Console.Error.WriteLine(ex.Message);
            }
            catch (FormatException) //If can Not parse
            {
                Console.Error.WriteLine("Input is NOT a valid number!");
            }
            catch (Exception ex) // Catch all exeptions
            {
                string errMassage = string.Format("{0} That leads to {1}", ex.Message, ex.GetType());
                Console.Error.WriteLine(errMassage);
            }
            //finally
            //{
            //    Console.WriteLine("So Long, and Thanks for All the Fish");
            //}
        }
    }
}

