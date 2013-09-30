using System;
using System.Collections.Generic;
using System.IO;

// Write a program that deletes from given text file all odd lines. The result should be in the same file.

class DeleteOddLines
{
    static void Main()
    {
        List<string> evenLinesText = new List<string>();

        StreamReader textFileRead = new StreamReader("textfile.txt");

        using (textFileRead)
        {
            int currentRow = 1;
            string currentLineText = textFileRead.ReadLine();

            while (currentLineText != null)
            {
                if (currentRow % 2 == 0)
                {
                    evenLinesText.Add(currentLineText);
                }

                currentLineText = textFileRead.ReadLine();
                currentRow++;
            }
        }

        StreamWriter textFileWrite = new StreamWriter("textfile.txt", false);

        using (textFileWrite)
        {
            foreach (var line in evenLinesText)
            {
                textFileWrite.WriteLine(line);
            }
        }
    }
}
