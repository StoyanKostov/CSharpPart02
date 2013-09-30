using System;
using System.IO;

// Write a program that concatenates two text files into another text file.

class ConcatenateTwoFiles
{
    static void Main()
    {
        StreamWriter concatenatedFile = new StreamWriter("concatenatedFile.txt");

        using (concatenatedFile)
        {
            StreamReader fileOne = new StreamReader("fileOne.txt");

            using (fileOne)
            {
                string fileOneText = fileOne.ReadToEnd();
                concatenatedFile.WriteLine(fileOneText);
            }

            StreamReader fileTwo = new StreamReader("fileTwo.txt");

            using (fileTwo)
            {
                string fileTwoText = fileTwo.ReadToEnd();
                concatenatedFile.Write(fileTwoText);
            }
            
        }
    }
}
