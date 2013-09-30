//#5: Write a program that reads a text file containing a square matrix of numbers and finds in the matrix an area of 
//size 2 x 2 with a maximal sum of its elements. 
//The first line in the input file contains the size of matrix N. Each of the next N lines contain N numbers separated by space. 
//The output should be a single number in a separate text file. Example:
//4
//2 3 3 4
//0 2 3 4		->	17
//3 7 1 2
//4 3 3 2


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class ReadMatrixmaxSum
{
    static void Main()
    {
        string path = @"D:\downloads\temp.txt"; // Enter the full filepath
        int[,] matrix = CreateArrayFromFile(path);
        int side = 2;
        int maxSum = MaxSumInmatrix(matrix, side);
        Console.WriteLine("--------------------");
        Console.WriteLine("MAX SUM OF ITEMS IS: " + maxSum);
        Console.WriteLine("--------------------");

        string pathWrite = @"c:\temp\output5.txt";//file to write
        StreamWriter streamWriter = new StreamWriter(pathWrite);//write the result
        using (streamWriter)
        {
            if (!File.Exists(pathWrite))//create a file to write in if not exists
            {
                File.Create(pathWrite);
            }
            streamWriter.Write(maxSum);
        }


    }

    static int[,] CreateArrayFromFile(string path)
    {
        StreamReader reader = new StreamReader(path);

        int matrixSize = 0;
        int[,] a = null;
        int row = 0;
        int col = 0;
        int startLine = 0;
        using (reader)
        {
            try
            {
                string line = reader.ReadLine();
                line = line.Replace(" ", string.Empty);//removes the whitespaces from a string
                while (line != null)
                {
                    if (startLine == 0)
                    {
                        matrixSize = Convert.ToInt32(line);
                        a = new int[matrixSize, matrixSize];
                        startLine++;
                        line = reader.ReadLine();
                    }
                    else
                    {
                        line = new string(line.ToList().Where(c => c != ' ').ToArray());//2nd option to remove the whitespaces from a string
                        for (col = 0; col < line.Length; col++)
                        {
                            a[row, col] = Convert.ToInt32(line.Substring(col, 1));
                        }
                        row++;
                        line = reader.ReadLine();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        Console.WriteLine("PRINT THE MATRIX");
        Console.WriteLine("--------------------");
        for (int i = 0; i < matrixSize; i++)
        {
            for (int k = 0; k < matrixSize; k++)
            {

                Console.Write(Convert.ToString(a[i, k]).PadLeft(4));
            }
            Console.WriteLine();
        }
        Console.WriteLine("--------------------");
        return a;
    }

    static int MaxSumInmatrix(int[,] a, int side)
    {
        int sum = 0;
        int maxSum = int.MinValue;
        int maxRow = 0;
        int maxCol = 0;

        int N = (int)Math.Sqrt(a.Length);
        int M = N;

        int z = 0;
        int t = 0;
        for (int i = 0; i <= N - side; i++) // rows
        {
            for (int k = 0; k <= M - side; k++) // cols
            {
                for (z = i; z < side + i; z++)
                {
                    for (t = k; t < side + k; t++)
                    {
                        sum = sum + a[z, t];
                    }
                }

                if (sum > maxSum)
                {
                    maxSum = sum;
                    maxRow = z - side;
                    maxCol = t - side;
                }
                sum = 0;
            }
        }
        Console.WriteLine("PRINT THE MAX SUM SUB-MATRIX: ");
        Console.WriteLine("--------------------");

        for (int i = 0; i < side; i++)
        {
            for (int k = 0; k < side; k++)
            {
                Console.Write(Convert.ToString(a[maxRow + i, maxCol + k]).PadLeft(4));
            }
            Console.WriteLine();
        }
        return maxSum;
    }
}