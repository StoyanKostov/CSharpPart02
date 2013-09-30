//#1: Write a program that reads a text file and prints on the console its odd lines.

using System;
using System.IO;

class PrintOddLines
{
    static void Main()
    {
        try
        {
            string path = @"c:\temp\temp.txt"; // Enter the full filepath
            using (StreamReader reader = new StreamReader(path))
            {
                int lineNumber = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    lineNumber++;
                    if (lineNumber % 2 == 1)
                    {
                        Console.WriteLine("Line {0}: {1}", lineNumber, line);
                    }
                    line = reader.ReadLine();
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("The process failed: {0}", e.ToString());
        }
    }
}
