using System;
using System.Collections.Generic;
using System.Linq;

class SequenceOfMaximalSum
{
    static void Main(string[] args)
    {
        /// Write a program that finds the sequence of maximal sum in given array.
        /// Example: {2, 3, -6, -1, 2, -1, 6, 4, -8, 8} -> {2, -1, 6, 4}
        /// Can you do it with only one loop (with single scan through the elements of the array)?

        Console.Write("Enter nummbers of the array separated by space: ");
        string input = Console.ReadLine();
        string[] arrNummbers = input.Split(' ');
        int[] inputArray = Array.ConvertAll<string, int>(arrNummbers, int.Parse);

        // Main logic
        int maxStartIndex = 0;
        int maxEndIndex = 0;
        int maxSum = int.MinValue;
 
        int cumulativeSum = 0;
        int maxStartIndexUntilNow = 0;
        for (int currentIndex = 0; currentIndex < inputArray.Length; currentIndex++)
        {
            int eachArrayItem = inputArray[currentIndex];
            cumulativeSum += eachArrayItem;
 
            if(cumulativeSum > maxSum)
            {
                maxSum = cumulativeSum;
                maxStartIndex = maxStartIndexUntilNow;
                maxEndIndex = currentIndex;
            }
            else if (cumulativeSum < 0)
            {
                maxStartIndexUntilNow = currentIndex+1;
                cumulativeSum = 0;
            }
        }
        
        // Consol output
        Console.Write("The sequence is: ");
        for (int i = maxStartIndex; i <= maxEndIndex; i++)
        {
            Console.Write("{0} ", inputArray[i]);
        }
    }
}