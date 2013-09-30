using System;
using System.Collections.Generic;
 
class GreedyDwarf
{
    static void Main()
    {
        string[] sepearators = { ", " };
        int[] valleyNumbers = Array.ConvertAll<string, int>(Console.ReadLine().Split(sepearators, StringSplitOptions.RemoveEmptyEntries), int.Parse);
        //int[] valleyNumbers = { 1, 3, -6, 7, 4, 1, 12 };

        int bestBalance = int.MinValue;
        int currentBalance = 0;

        int m = int.Parse(Console.ReadLine());
        int[][] patterns = new int[m][];
 
        for (short i = 0; i < m; i++)
        {
            patterns[i] = Array.ConvertAll<string, int>(Console.ReadLine().Split(sepearators, StringSplitOptions.RemoveEmptyEntries), int.Parse);
        }
 
        for (short row = 0; row < patterns.GetLength(0); row++)
        {
            currentBalance = calculatePattern(patterns[row], valleyNumbers);

            if (bestBalance < currentBalance)
            {
                bestBalance = currentBalance;
            }
        }
        Console.WriteLine(bestBalance);
    }

    static private int calculatePattern(int[] patterns, int[] valleyNumbers)
    {
        List<int> stepsCollections = new List<int>() {0};
        int step = 0;
        int col = 0;
        int balance = valleyNumbers[0];

        while (true)
        {
            
            step = step + patterns[col];

            if (step >= valleyNumbers.Length || step < 0 || stepsCollections.Contains(step))
            {
                break;
            }

            balance = valleyNumbers[step] + balance;

            col++;

            if (col >= patterns.Length)
            {
                col = 0;
            }

            stepsCollections.Add(step);

        }
        return balance;
    }
}