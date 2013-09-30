using System;
using System.Collections.Generic;
using System.Linq;

class Variations
{
    static void Main(string[] args)
    {
        /// Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N].
        /// Example: N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}
        Console.WriteLine("Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N].");
        Console.WriteLine("Example: N = 3, K = 2 -> {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}");
        
        // Consol input
        Console.Write("Enter number N: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter number K: ");
        int k = int.Parse(Console.ReadLine());

        // Main logic
        int[] arr = new int[k];

        VariationsOfElements(arr, n);
    }

    static void VariationsOfElements(int[] arr, int n, int index = 0)
    {
        if (index == arr.Length)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("");
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                arr[index] = i;
                VariationsOfElements(arr, n, index + 1);
            }
        }
    }
}

