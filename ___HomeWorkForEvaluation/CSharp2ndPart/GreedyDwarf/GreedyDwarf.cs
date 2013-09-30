using System;

class GreedyDwarf
{
    private static long PatternProcess(int[] valley)
    {
        string[] input = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] pattern = new int[input.Length];

        for (int i = 0; i < pattern.Length; i++)
        {
            pattern[i] = int.Parse(input[i]);
        }

        bool[] isVisited = new bool[valley.Length];
        isVisited[0] = true;
        long sumOfCoins = valley[0];
        int position = 0;
        bool goOut = true;
        
        while (goOut == true)
        {
            for (int i = 0; i < pattern.Length; i++)
            {
                int move = position + pattern[i];

                if (move >= 0 && move < valley.Length && isVisited[move] == false)
                {
                    isVisited[move] = true;
                    sumOfCoins += valley[move];
                    position = move;                    
                }
                else
                {
                    goOut = false;
                    return sumOfCoins;
                }
            }
            
        }

        return 0;
    }

    static void Main()
    {
        string[] input = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
 
        int[] valley = new int[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            valley[i] = int.Parse(input[i]);
        }

        int numOfPattern = int.Parse(Console.ReadLine());
        long maxSum = long.MinValue;

        for (int i = 1; i < numOfPattern; i++)
        {
            if (PatternProcess(valley) > maxSum)
            {
                maxSum = PatternProcess(valley);
            }          
        }
        Console.WriteLine(maxSum);
    }
}
