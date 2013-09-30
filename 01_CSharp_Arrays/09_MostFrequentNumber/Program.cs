using System;
using System.Collections.Generic;
using System.Linq;

class MostFrequentNumber
{
    static void Main(string[] args)
    {
        /// Write a program that finds the most frequent number in an array. 
        /// Example: {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} -> 4 (5 times)

        // Consol Input
        Console.Write("Enter nummbers of the array separated by space: ");
        string input = Console.ReadLine();
        string[] arrNummbers = input.Split(' ');
        int[] inputArray = Array.ConvertAll<string, int>(arrNummbers, int.Parse);

        // main Logic
        int value;
        int? frequentValue = null;
        int count = 1;
        int bestCount = 0;

        for (int i = 0; i < inputArray.Length; i++)
        {
            value = inputArray[i];
            for (int k = (i + 1); k < inputArray.Length; k++)
            {
                if (value == inputArray[k])
                {
                    count += 1;
                }
            }
            if (count > bestCount)
            {
                bestCount = count;
                frequentValue = value;
                count = 1;
            }
        }
        Console.WriteLine("Most frequent number is {0} ({1} times)", frequentValue, bestCount);
    }
}