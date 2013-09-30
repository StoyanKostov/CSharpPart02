using System;
using System.Collections.Generic;
using System.Linq;

class MaximalSum
{
    static void Main(string[] args)
    {
        /// We are given a matrix of strings of size N x M. 
        /// Sequences in the matrix we define as sets of several neighbor elements located on the same line, column or diagonal.
        /// Write a program that finds the longest sequence of equal strings in the matrix.

        //// Consol Input
        //Console.Write("Number of rows = ");
        //int rows = int.Parse(Console.ReadLine());
        //Console.Write("Number of columns = ");
        //int cols = int.Parse(Console.ReadLine());
        //
        ////initialize the matrix
        //string[,] matrix = new int[rows, cols];
        //
        //for (int row = 0; row < rows; row++)
        //{
        //    for (int col = 0; col < cols; col++)
        //    {
        //        Console.Write("Enter string row {0}, column {1}: ", row + 1, col + 1);
        //        matrix[row, col] = Console.ReadLine();
        //    }
        // }

        // Declare and initialize the matrix
        string[,] matrix = 
		{
			{"ha", "ha", "ha", "gh"},
			{"ha", "ha", "r", "sd"},
			{"ha", "v", "f", "df"},
			{"ha", "g", "d", "sr"},
		};
        int rows = 4;
        int cols = 4;

        // Main Logic
        int bestSequence = 0;
        int bestCurrentSequence = 0;
        string bestElement = " ";
        
        // Horizontal
        for (int row = 0; row < rows; row++)
        {
            int currentSequence = 1;
            for (int col = 0; col < cols - 1; col++)
            {
                if (matrix[row, col] == matrix[row, col + 1])
	            {
                   currentSequence += 1;
	            }
                if (currentSequence > bestCurrentSequence)
                {
                    bestCurrentSequence = currentSequence;
                    bestElement = matrix[row, col];
                }
            }
        }

        if (bestCurrentSequence > bestSequence)
        {
            bestSequence = bestCurrentSequence;
        }
        bestCurrentSequence = 0;

        // Vertical
        for (int col = 0; col < cols; col++)
        {
            int currentSequence = 1;
            for (int row = 0; row < rows - 1; row++)
            {
                if (matrix[row, col] == matrix[row + 1, col])
                {
                    currentSequence += 1;
                }
                if (currentSequence > bestCurrentSequence)
                {
                    bestCurrentSequence = currentSequence;
                    bestElement = matrix[row, col];
                }
            }
        }

        if (bestCurrentSequence > bestSequence)
        {
            bestSequence = bestCurrentSequence;
        }
        bestCurrentSequence = 0;

        // Diagonal left to right
        for (int row = 0; row < rows - 1; row++)
        {
            int currentSequence = 1;
            for (int col = 0; col < cols - 1; col++)
            {
                if (matrix[row, col] == matrix[row + 1, col + 1])
                {
                    currentSequence += 1;
                }
                if (currentSequence > bestCurrentSequence)
                {
                    bestCurrentSequence = currentSequence;
                    bestElement = matrix[row, col];
                }
            }
        }

        if (bestCurrentSequence > bestSequence)
        {
            bestSequence = bestCurrentSequence;
        }
        bestCurrentSequence = 0;

        // Diagonal right to left
        for (int row = 0; row < rows - 1; row++)
        {
            int currentSequence = 1;
            for (int col = 1; col < cols; col++)
            {
                if (matrix[row, col] == matrix[row + 1, col - 1])
                {
                    currentSequence += 1;
                }
                if (currentSequence > bestCurrentSequence)
                {
                    bestCurrentSequence = currentSequence;
                    bestElement = matrix[row, col];
                }
            }
        }

        if (bestCurrentSequence > bestSequence)
        {
            bestSequence = bestCurrentSequence;
        }
        bestCurrentSequence = 0;

        // Consol output
        Console.WriteLine("The matrix is as follows:");
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write("{0,2} ", matrix[row, col]);
            }
            Console.WriteLine();
        }

        Console.WriteLine("The most frequent element is: {0}, {1} times", bestElement, bestSequence);
    }
}
