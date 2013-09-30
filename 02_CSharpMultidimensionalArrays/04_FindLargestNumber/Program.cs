using System;
using System.Collections.Generic;
using System.Linq;

class FindLargestNumber
{
    static void Main(string[] args)
    {
        /// Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch()
        /// finds the largest number in the array which is ≤ K.

        // Consol Input
        int[] arr = new int[]{9, 2, 66, 55, 7, 4};
        int[] arrCopy = (int[]) arr.Clone();
        int k = 66;

        // Main Logic
        foreach (var item in arr)
        {
            Console.Write("{0} ", item);
        }
        Console.WriteLine();

        Array.Sort(arr);

        int searchedNumber = Array.BinarySearch(arr, k);
        if (searchedNumber < -1)
        {
            int number = arr[~searchedNumber - 1];
            Console.WriteLine("Largest number smaller than {0} is {1} and its index in given array is {2}", k, arr[~searchedNumber - 1], (Array.IndexOf(arrCopy, number)));
        }
        else if (searchedNumber == -1)
        {
            Console.WriteLine("All numbers are greater than {0}", k);
        }
        else
        {
            int number = arr[searchedNumber];
            Console.WriteLine("There is a match to {0} and its index in given array is {1}", k, (Array.IndexOf(arrCopy, number)));
        }
    }
}

