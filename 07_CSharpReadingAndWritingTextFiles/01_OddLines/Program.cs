/// Write a program that reads a text file and prints on the console its odd lines.

using System;
using System.IO;

class OddLines
{
    static void Main(string[] args)
    {
        try
        {
            using (StreamReader sr = new StreamReader("text.txt"))
            {
                int lineNum = 0;
                string line = string.Empty;
                while (line != null) // if there's no line ReadLine() returns null
                {
                    lineNum++;
                    line = sr.ReadLine();
                    if (lineNum % 2 != 0) // if line is odd
                    {
                        Console.WriteLine(line);
                    }
                }
            }
        }
        catch (Exception e)
        {
            // Let the user know what went wrong.
            Console.Error.WriteLine("The process failed: {0}", e.Message);
        }
    }
}
