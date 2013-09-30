using System;
using System.Collections.Generic;

class MaximalIncreasingSequence
{
    static void Main(string[] args)
    {
        /// Write a program that finds the maximal increasing sequence in an array. 
        /// Example: {3, 2, 3, 4, 2, 2, 4} -> {2, 3, 4}.

        List<int> maxSequence = new List<int>();
        List<int> currentSequence = new List<int>();

        // Consol input
        Console.Write("Enter nummbers of the array separated by space: ");
        string input = Console.ReadLine();
        string[] arrNummbers = input.Split(' ');
        int[] arr = Array.ConvertAll<string, int>(arrNummbers, int.Parse);
        
        // Main logic
        for (int i = 0; i < (arr.Length - 1); i++)
        {
            if (arr[i] == arr[i + 1] - 1)
            {
                currentSequence.Add(arr[i]);
            }
            else
            {
                currentSequence.Clear();
            }

            if (currentSequence.Count > maxSequence.Count)
            {
                maxSequence = new List<int>(currentSequence); // Makes DEEP COPY of list
            }
        }

        // Consol output
        foreach (var item in maxSequence)
        {
            Console.Write(item);
            Console.Write(", ");
        }
        Console.WriteLine(maxSequence[maxSequence.Count - 1] + 1); // Print last element
    }
}