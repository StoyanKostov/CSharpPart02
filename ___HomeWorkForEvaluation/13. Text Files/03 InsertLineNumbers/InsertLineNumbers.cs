using System;
using System.IO;

// Write a program that reads a text file and inserts line numbers in front of each of its lines. The result should be written to another text file.

class InsertLineNumbers
{
    static void Main()
    {
        StreamWriter fileWithLines = new StreamWriter("fileWithLines.txt");

        using (fileWithLines)
        {
            StreamReader fileWithoutLines = new StreamReader("fileWithoutLines.txt");

            using (fileWithoutLines)
            {
                int currentLineNumber = 1;
                string currentLineText = fileWithoutLines.ReadLine();

                while (currentLineText != null)
                {
                    fileWithLines.WriteLine("Line {0}: {1}", currentLineNumber, currentLineText);
                    currentLineNumber++;
                    currentLineText = fileWithoutLines.ReadLine();
                }
            }
        }
    }
}
