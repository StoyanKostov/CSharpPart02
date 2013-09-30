/// Write a method that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).

using System;
using System.Collections.Generic;
using System.Linq;

class Bigger
{
    static bool BiggerThanNeighbors(int index, int[] array)
    {
        bool isBigger = false;
        
        if ((array[index - 1] < array[index]) && (array[index] > array[index + 1]))
        {
            isBigger = true;
        }

        return isBigger;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Write a method that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).\n");

        // Allocates array
        Console.WriteLine("Enter number of elements of the array:");
        int arrayLength = int.Parse(Console.ReadLine());
        int[] array = new int[arrayLength];
        Console.WriteLine("Enter each element:");
        for (int i = 0; i < arrayLength; i++)
        {
            Console.Write("Position: {0} Element: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        
        Console.WriteLine("Enter the position of number to check (between 1 and {0}): ", array.Length - 2);
        int position = int.Parse(Console.ReadLine());

        // Method call
        bool result = BiggerThanNeighbors(position, array);

        // Consol output
        Console.WriteLine("The element at given position {0} is bigger than its neighbors:\n{1}", position, result);
    }
}

