using System;
using System.Collections.Generic;
using System.Linq;

class BinarySearch
{

    static int Search(int[] a, int element, int index)
    {
        if (a[index] == element)
        {
            return index;
        }
        else if (element > a[index])
        {
            if ((index + index / 2) > (a.Length - 1)) // Disturbing If statments – cheks for the last Index
            {
                index = a.Length - 1;
            }
            else
            {
                index = index + index / 2;
            }
        }
        else if (element < a[index])
        {
            index = index / 2;
        }
        return Search(a, element, index);
    }

    static void Main()
    {
        /// Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm (find it in Wikipedia).
        Console.WriteLine(" Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm (find it in Wikipedia).");

        // Consol Input
        Console.Write("Enter nummbers of the array separated by space: ");
        string input = Console.ReadLine();
        string[] arrNummbers = input.Split(' ');
        int[] inputArray = Array.ConvertAll<string, int>(arrNummbers, int.Parse);

        Console.Write("Enter the searched element: ");
        int element = int.Parse(Console.ReadLine());

        // Main logic
        Array.Sort(inputArray);
        int index = (inputArray.Length - 1) / 2 + 1; // Find middle of the Arrey to the cieling

        Console.WriteLine("The index of the given element in sorted array is {0}", Search(inputArray, element, index));
    }
}