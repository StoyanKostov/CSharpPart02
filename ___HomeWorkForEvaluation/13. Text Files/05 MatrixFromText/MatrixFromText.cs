using System;
using System.IO;

/* Write a program that reads a text file containing a square matrix of numbers and finds in the matrix an area of size 2 x 2 with a maximal sum of its elements. 
 * The first line in the input file contains the size of matrix N. Each of the next N lines contain N numbers separated by space. 
 * The output should be a single number in a separate text file */

class MatrixFromText
{
    static int[,] integersArray;
    static int matrixSize;

    private static void PutCurrentLineIntoArray(string currentLineText, int currentLineNumber)
    {
        int currentRowInArray = currentLineNumber - 1;
        int currentNumberStartIndex = 0;
        int currentNumberEndIndex;

        // There will be "matrix - 1" number of spaces in the line, so we will create a loop that will run "matrix - 1" times
        for (int index = 0; index < matrixSize; index++)
        {
            int currentInteger;

            // At the last loop we will need to get the number without looking for the next space
            if (index == (matrixSize - 1))
            {
                currentInteger = Convert.ToInt32(currentLineText.Substring(currentNumberStartIndex, currentLineText.Length - currentNumberStartIndex));
                integersArray[currentRowInArray, index] = currentInteger;
            }
            else
            {
                currentNumberEndIndex = currentLineText.IndexOf(" ", currentNumberStartIndex);
                currentInteger = Convert.ToInt32(currentLineText.Substring(currentNumberStartIndex, currentNumberEndIndex - currentNumberStartIndex));
                integersArray[currentRowInArray, index] = currentInteger;

                currentNumberStartIndex = currentNumberEndIndex + 1;
            }
        }
    }

    private static long  CalculateMaxSumArea(int[,] integersArray)
    {
        // Create a loop to calculate the sum of the 2x2 area
        long biggestSum = Int64.MinValue;

        for (int row = 0; row < matrixSize - 1; row++)
        {
            for (int col = 0; col < matrixSize - 1; col++)
            {
                long currentSum = integersArray[row, col] + integersArray[row, col + 1] + integersArray[row + 1, col] + integersArray[row + 1, col + 1];

                if (currentSum > biggestSum)
                {
                    biggestSum = currentSum;
                }
            }
        }

        return biggestSum;
    }

    static void Main()
    {
        StreamReader matrixFile = new StreamReader("matrix.txt");

        // Initialize the array and put the matrix from the file into it
        using (matrixFile)
        {
            matrixSize = Convert.ToInt32(matrixFile.ReadLine());
            integersArray = new int[matrixSize, matrixSize];

            string currentLineText = matrixFile.ReadLine();
            int currentLineNumber = 1;

            while (currentLineText != null)
            {
                PutCurrentLineIntoArray(currentLineText, currentLineNumber);
                currentLineText = matrixFile.ReadLine();
                currentLineNumber++;
            }
        }

        long maximumSum = CalculateMaxSumArea(integersArray);

        StreamWriter result = new StreamWriter("result.txt");

        using (result)
        {
            result.Write(maximumSum);
        }
    }
}
