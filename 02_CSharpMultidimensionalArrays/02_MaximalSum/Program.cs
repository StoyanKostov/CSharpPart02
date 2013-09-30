using System;
using System.Collections.Generic;
using System.Linq;

class MaximalSum
{
    static void Main(string[] args)
    {
        /// Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

        // Consol Input
        Console.Write("Number of rows = ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Number of columns = ");
        int cols = int.Parse(Console.ReadLine());

        //initialize the matrix
        int[,] matrix = new int[rows, cols];

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write("Enter number row {0}, column {1}: ", row + 1, col + 1);
                matrix[row, col] = int.Parse(Console.ReadLine());
            }
         }

        //// Declare and initialize the matrix
        //int[,] matrix = 
		//{
		//	{0, 2, 4, 0, 9, 5},
		//	{7, 1, 3, 3, 2, 1},
		//	{1, 3, 9, 8, 5, 6},
		//	{4, 6, 7, 9, 1, 0},
		//};
        //int rows = 4;
        //int cols = 6;

        // Main Logic
       
        int bestSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;


        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                if ((col < cols - 3) && (row < rows - 3))
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                              matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                              matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        bestRow = row;
                        bestCol = col;
                    }
                }
            }
        }

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

        Console.WriteLine("Maximal sum is {0}", bestSum);
        Console.WriteLine("the square 3 x 3 that has maximal sum is as follows:");
        for (int row = bestRow; row < bestRow + 3; row++)
        {
            for (int col = bestCol; col < bestCol + 3; col++)
            {
                Console.Write("{0,2} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}
