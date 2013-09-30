using System;
using System.IO;

/* Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines 
 * that are different. Assume the files have equal number of lines */

class CompareTwoFiles
{
    static void Main()
    {
        StreamReader fileOne = new StreamReader("fileOne.txt");
        StreamReader fileTwo = new StreamReader("fileTwo.txt");

        int numberOfEqualLines = 0;
        int numberOfDifferentLines = 0;

        using (fileOne)
        {
            using (fileTwo)
            {
                string currentLineTextFileOne = fileOne.ReadLine();
                string currentLineTextFileTwo = fileTwo.ReadLine();

                while (currentLineTextFileOne != null)
                {
                    if (currentLineTextFileOne == currentLineTextFileTwo)
                    {
                        numberOfEqualLines++;
                    }
                    else
                    {
                        numberOfDifferentLines++;
                    }

                    currentLineTextFileOne = fileOne.ReadLine();
                    currentLineTextFileTwo = fileTwo.ReadLine();
                }
            }
        }

        Console.WriteLine("There were {0} lines that were the same in the files", numberOfEqualLines);
        Console.WriteLine("The rest {0} lines were different\n", numberOfDifferentLines);
    }
}
