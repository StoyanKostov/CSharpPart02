///You are given a sequence of positive integer values written into a string, separated by spaces.
///Write a function that reads these values from given string and calculates their sum. 
///Example: string = "43 68 9 23 318" -> result = 461

using System;
using System.Collections.Generic;

class CalculateSum
{
    // Recoursion function that calculates int array any length
    static int Sum(int[] a, int index = 0)
    {
        if (a[index] == a[a.Length - 1])
        {
            return a[a.Length - 1];
        }
        return a[index] + Sum(a, index + 1);
    }
    
    static void Main(string[] args)
    {
        /// Consol Input
        Console.Write("Enter numbers separated with spase: ");
        string input = Console.ReadLine();
        
        /// Main logic
        
        // Creates string array from inputed string
        string[] inputArray = input.Split(' '); 

        // Creates int array from string array
        int[] numbers = new int[inputArray.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(inputArray[i]);
        }

        // Call Recoursion function to calculate the sum
        int result = Sum(numbers);

        /// Consol output
        Console.WriteLine("Sum of given numbers is: {0}", result);
    }
}
