using System;
using System.Collections.Generic;

class MaximalSum
{
    static void Main(string[] args)
    {
        /// Write a program that reads two integer numbers N and K and an array of N elements from the console. Find in the array those K elements that have maximal sum.
        Console.WriteLine("Write a program that reads two integer numbers N and K and an array of N elements from the console. Find in the array those K elements that have maximal sum.");

        int maxSum = 0;

        //Console input
        Console.Write("Enter number K: ");
        int k = int.Parse(Console.ReadLine());

        Console.Write("Enter number N: ");
        int n = int.Parse(Console.ReadLine());

        // Allocate array
        int[] array = new int[n];
                
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter index {0}: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        // Main Logic
        Array.Sort(array);
        Array.Reverse(array);

        for (int i = 0; i < k; i++)
        {
            maxSum += array[i];
        }

        //Consol output
        Console.WriteLine("Maximal sum of {0} elements from int array is {1}.", k, maxSum);
    }
}