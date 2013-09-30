using System;
using System.Collections.Generic;
using System.Linq;

class SequenceOfGivenSum
{
    static void Main(string[] args)
    {
        /// Write a program that finds in given array of integers a sequence of given sum S (if present).
        /// Example: {4, 3, 1, 4, 2, 5, 8}, S=11 -> {4, 2, 5}
        
        // Consol Input
        Console.Write("Enter nummbers of the array separated by space: ");
        string input = Console.ReadLine();
        string[] arrNummbers = input.Split(' ');
        int[] inputArray = Array.ConvertAll<string, int>(arrNummbers, int.Parse);

        Console.Write("Enter the sum: ");
        int givenSum = int.Parse(Console.ReadLine());

        // Main Login
        int currentSum = 0;
        List<int> sequence = new List<int>();
        for (int i = 0; i < inputArray.Length; i++)
        {
            currentSum = inputArray[i];
            sequence.Add(inputArray[i]);

            for (int k = i + 1; k < inputArray.Length; k++)
            {
                currentSum += inputArray[k];
                
                if (currentSum <= givenSum)
                {
                    sequence.Add(inputArray[k]);
                    if (currentSum == givenSum)
                    {
                        Console.WriteLine("A sequence is: ");
                        foreach (var item in sequence)
                        {
                            Console.Write("{0} ",item);
                        }
                        Console.WriteLine(" ");
                        sequence.Clear();
                        break;
                    }
                    
                }
                else
                {
                    sequence.Clear();
                }
            }
        }
        Console.WriteLine("There's no such sequense!");
    }
}

