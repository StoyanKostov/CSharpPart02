using System;
using System.Collections.Generic;
using System.Linq;

class MatrixExamplesB
{
    static void Main(string[] args)
    {
        /// Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)
        //  7 11 14 16  
        //  4  8 12 15  
        //  2  5  9 13
        //  1  3  6 10  
        
        // Consol Input
        Console.Write("Number of rows and columns = ");
        int rows = int.Parse(Console.ReadLine());
        int cols = rows;

        // Main Logic
        int[,] matrix = new int[rows, cols];
        int i = 1; // Numbers from 1 to ...
        int k = 0;

        // First loop sets values as shown below
        //  7  0  0  0  
        //  4  0  0  0  
        //  2  5  0  0
        //  1  3  6 10  
        for (int row = rows - 1; row >= 0; row--) // Starts from last row 
        {
            k = row;
            for (int col = 0; col < rows - row; col++) // Starts from first col
            {
                matrix[k, col] = i;
                i += 1;
                k += 1;  // increment the row for the next value plus 1, the column is incremented in for (AFTERTHOUGHT)
            }
        }

        // Second loop sets values as shown below
        //  0 11 14 16  
        //  0  0 12 15  
        //  0  0  0 13
        //  0  0  0  0 
        for (int row = 0; row < rows - 1; row++)
        {
            k = 0;
            for (int col = row + 1; col < cols; col++)
            {
                matrix[k, col] = i;
                i += 1;
                k += 1;
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
