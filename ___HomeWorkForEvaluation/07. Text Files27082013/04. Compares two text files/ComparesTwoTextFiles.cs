//04. Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different. Assume the files have equal number of lines.

using System;
using System.Text;
using System.IO;


class ComparesTwoTextFiles
{
    static void Main()
    {
        try
        {
            StreamReader readerFirstFile = new StreamReader(@"C:\Compare1.txt", Encoding.GetEncoding("ASCII"));
            StreamReader readerSecondFile = new StreamReader(@"C:\Compare2.txt", Encoding.GetEncoding("ASCII"));

            int equalLines = 0;
            int differentLines = 0;

            using (readerFirstFile)
            {
                using (readerSecondFile)
                {
                    string line1 = readerFirstFile.ReadLine();
                    string line2 = readerSecondFile.ReadLine();

                    while (line1 != null && line2 != null)
                    {
                        if (line1 == line2)
                        {
                            equalLines++;
                        }
                        else
                        {
                            differentLines++;
                        }
                        line1 = readerFirstFile.ReadLine();
                        line2 = readerSecondFile.ReadLine();
                    }
                }
            }
            Console.WriteLine("The number of equal lines is: {0}", equalLines);
            Console.WriteLine("The number of different lines is: {0}", differentLines);
        }
        catch (Exception e)
        {
            Console.WriteLine("The process failed: {0}", e.ToString());
        }
    }
}

