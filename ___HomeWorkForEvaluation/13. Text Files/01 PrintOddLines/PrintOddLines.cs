using System;
using System.IO;

// Write a program that reads a text file and prints on the console its odd lines.

class PrintOddLines
{
    static void Main()
    {
        StreamReader fileToRead = new StreamReader("file.txt");

        using (fileToRead)
        {
            string currentLineText = fileToRead.ReadLine();
            int currentLineNumber = 1;

            while (currentLineText != null)
            {
                if ((currentLineNumber % 2) != 0)
                {
                    Console.WriteLine(currentLineText);
                }

                currentLineText = fileToRead.ReadLine();
                currentLineNumber++;
            }
        }
    }
}
