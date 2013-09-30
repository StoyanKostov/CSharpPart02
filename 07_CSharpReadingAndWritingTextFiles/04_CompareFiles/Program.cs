/// Write a program that compares two text files line by line and prints the number 
/// of lines that are the same and the number of lines that are different.
/// Assume the files have equal number of lines.

using System;
using System.IO;

class CompareFilesLineByLine
{
    static void Main(string[] args)
    {

        try
        {
            using (StreamReader firstFile = new StreamReader("text01.txt"))
            using (StreamReader secondFile = new StreamReader("text02.txt"))
            {
                int equalLines = 0;
                int diffrentLines = 0;
                string firstFileLine = string.Empty;
                string secondFileLine = string.Empty;

                while (true) 
                {
                    firstFileLine = firstFile.ReadLine();
                    secondFileLine = secondFile.ReadLine();

                    if (firstFileLine == null || secondFileLine == null) // if there's no line ReadLine() returns null
                    {
                        break;
                    }

                    if ( firstFileLine.Equals(secondFileLine) )
                    {
                        equalLines++;
                    }
                    else
                    {
                        diffrentLines++;
                    }
                }
                Console.WriteLine("The number of same lines is {0}\nThe number of diffrent lines is {1}", equalLines, diffrentLines);
            }
        }
        catch (Exception e)
        {
            // Let the user know what went wrong.
            Console.Error.WriteLine("The process failed: {0}", e.Message);
        }
        //Console.WriteLine("stoyan".Equals("stoyan"));
    }
}

