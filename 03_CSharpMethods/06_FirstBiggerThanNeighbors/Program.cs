/// Write a method that returns the index of the first element in array that is bigger than its neighbors, or -1, if there’s no such element.
/// Use the method from the previous exercise.

using System;
using System.Collections.Generic;
using System.Linq;

class Bigger
{
    // Method from previous exersise
    static bool BiggerThanNeighbors(int index, int[] array)
    {
        bool isBigger = false;

        if ((array[index - 1] < array[index]) && (array[index] > array[index + 1]))
        {
            isBigger = true;
        }

        return isBigger;
    }

    // New method that utilise method from previous exersise
    static int FirstBiggerThanNeighbors(int[] array)
    {
        int firstBigger = -1;

        for (int i = 1; i < (array.Length - 1); i++)
        {
            if (BiggerThanNeighbors(i, array))
            {
                firstBigger = i;
                break;
            }
        }
        return firstBigger;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Write a method that returns the index of the first element in array that is bigger than its neighbors, or -1, if there’s no such element.\n");

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

        // Method call
        int result = FirstBiggerThanNeighbors(array);

        // Consol output
        Console.WriteLine("The first element bigger than its neighbors is at position: {0}", result);
    }
}

