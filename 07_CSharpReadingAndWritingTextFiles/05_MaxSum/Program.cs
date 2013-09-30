/// Write a program that reads a text file containing a square matrix of numbers and finds in the matrix an area of size 2 x 2 with a maximal sum of its elements.
/// The first line in the input file contains the size of matrix N. Each of the next N lines contain N numbers separated by space.
/// The output should be a single number in a separate text file.

using System;
using System.IO;

class MatixMaxSum
{
    static void Main(string[] args)
    {
        try
        {
            using (StreamWriter resultWriter = new StreamWriter("resultText.txt"))
            using (StreamReader sr = new StreamReader("text01.txt"))
            {
                string[] lineNumbers = sr.ReadLine().Split(' '); //Takes line by line and parse them to arrays

                int matrixSize = lineNumbers.Length;
                int[,] matrix = new int[matrixSize, matrixSize]; // Creates matrix to be filled

                // Fills matrix with values from file
                for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                {
                    for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                    {
                        matrix[row, col] = int.Parse(lineNumbers[col]);
                        //Console.Write(matrix[row, col]);
                    }

                    lineNumbers = sr.ReadLine().Split(' ');
                    //Console.WriteLine();
                }

                // Writes result in file
                resultWriter.WriteLine(MatrixBestSum(matrix));
            }

            Console.WriteLine("Success!");
        }
        catch (Exception e)
        {
            // Let the user know what went wrong.
            Console.Error.WriteLine("The process failed: {0}", e.Message);
        }
    }

    // help function that finds best sum of matrix in area of size 2 x 2
    static int MatrixBestSum(int[,] matrix)
    {
        int currentSum = int.MinValue;
        int bestSum = int.MinValue;

        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                currentSum = matrix[row, col] + matrix[row, (col + 1)] + 
                             matrix[(row + 1), col] + matrix[(row + 1), (col + 1)];
                
                if (currentSum > bestSum)
                {
                    bestSum = currentSum;
                }
            }
        }
        return bestSum;
    }
}

