using System;
using System.Collections.Generic;
using System.IO;

// Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file

class SortStrings
{
    static void Main()
    {
        StreamWriter sortedFile = new StreamWriter("sortedStrings.txt");

        using (sortedFile)
        {
            StreamReader unsortedFile = new StreamReader("unsortedStrings.txt");
            List<string> listOfStrings = new List<string>();

            using (unsortedFile)
            {
                string currentLineText = unsortedFile.ReadLine();

                while (currentLineText != null)
                {
                    listOfStrings.Add(currentLineText);
                    currentLineText = unsortedFile.ReadLine();
                }
            }

            listOfStrings.Sort();

            foreach (var lineOfText in listOfStrings)
            {
                sortedFile.WriteLine(lineOfText);
            }
        }
    }
}
