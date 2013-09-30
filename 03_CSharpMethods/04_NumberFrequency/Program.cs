/// Write a method that counts how many times given number appears in given array. Write a test program to check if the method is working correctly.

using System;
using System.Collections.Generic;
using System.Linq;

public class NumberInArray
{

    public static int NumberFrequency(int number, int[] givenArray)
    {
        int counter = 0;

        foreach (var item in givenArray)
        {
            if (number == item)
            {
                counter++;
            }
        }

        return counter;
    }

    static void Main(string[] args)
    {
        //Consol input
        Console.WriteLine("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        // Allocates array
        Console.WriteLine("Enter number of elements of the array:");
        int arrayLength = int.Parse(Console.ReadLine());
        int[] array = new int[arrayLength];

        Console.WriteLine("Enter each element:");
        for (int i = 0; i < arrayLength; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        // Main logic
        int frequency = NumberFrequency(number, array);

        //Consol output
        Console.WriteLine("Your number apears {0} in given array", frequency);
    }
}

