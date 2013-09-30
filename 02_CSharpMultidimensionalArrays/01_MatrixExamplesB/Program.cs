﻿using System;
using System.Collections.Generic;
using System.Linq;

class MatrixExamplesB
{
    static void Main(string[] args)
    {
        /// Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)
        //  1  8  9 16  
        //  2  7 10 15  
        //  3  6 11 14
        //  4  5 12 13

        // Consol Input
        Console.Write("Number of rows = ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Number of columns = ");
        int cols = int.Parse(Console.ReadLine());

        // Main Logic
        int[,] matrix = new int[rows, cols];

        for (int row = 1; row <= rows; row++)
        {
            int stepValue = 0;
            for (int col = 1; col <= cols; col++)
            {
                if (col % 2 == 0)
                {
                    matrix[row - 1, col - 1] = stepValue + rows - row + 1;
                }
                else
                {
                    matrix[row - 1, col - 1] = row + stepValue;
                }
                stepValue += rows;
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
    }
}
