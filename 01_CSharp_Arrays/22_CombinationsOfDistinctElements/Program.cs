using System;
using System.Collections.Generic;
using System.Linq;

class CombinationsOfDistinctElements
{
    static void Main(string[] args)
    {
        /// Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N].
        /// Example: N = 5, K = 2 -> {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}
        Console.WriteLine("Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N].");
        Console.WriteLine("Example:	N = 5, K = 2 -> {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}");

        // Consol input
        Console.Write("Enter number N: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter number K: ");
        int k = int.Parse(Console.ReadLine());

        // Main logic
        int[] arr = new int[k];

        VariationsOfElements(arr, n);
    }

    static void VariationsOfElements(int[] array, int n, int index = 0, int k = 1)
    {
        if (index == array.Length)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        else
        {
            for (int j = k; j <= n; j++)
            {
                array[index] = j;
                VariationsOfElements(array, n, index + 1, j + 1);
            }
        }
    }
}

