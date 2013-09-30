using System;
using System.Collections.Generic;
using System.Linq;

class ArraySort
{
    static void Main(string[] args)
    {
        /// Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
        /// Use the "selection sort" algorithm: Find the smallest element, move it at the first position,
        /// find the smallest from the rest, move it at the second position, etc.

        // Consol input
        Console.Write("Enter nummbers of the array separated by space: ");
        string input = Console.ReadLine();
        List<int> arr = input.Split(' ').Select(n => int.Parse(n)).ToList();
        List<int> orderedArr = new List<int>();

        // Main Logic
        while (arr.Count > 0)
        {
            int currentMin = arr[0];
            for (int i = 1; i < arr.Count; i++)
            {
                if (currentMin > arr[i])
                {
                    currentMin = arr[i];
                }
            }
            orderedArr.Add(currentMin);
            arr.Remove(currentMin);
        }

        // Consol output
        foreach (var item in orderedArr)
        {
            Console.WriteLine(item);
        }
    }
}

