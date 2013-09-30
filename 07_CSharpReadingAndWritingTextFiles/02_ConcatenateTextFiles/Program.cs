/// Write a program that concatenates two text files into another text file.

using System;
using System.IO;

class ConcatenateTwoTextFiles
{
    static void Main(string[] args)
    {
        try
        {
            // Main logic
            using (StreamWriter resultWriter = new StreamWriter("resultText.txt"))
            {
                resultWriter.WriteLine(FileRead("text01.txt")); 
                resultWriter.WriteLine(FileRead("text02.txt"));
            }
            
            Console.WriteLine("Success!");
        }
        catch (Exception e)
        {
            // Let the user know what went wrong.
            Console.Error.WriteLine("The process failed: {0}", e.Message);
        }
    }

    // Help method that reads files
    static string FileRead(string filePath)
    {
        using (StreamReader sr = new StreamReader(filePath))
        {
            return sr.ReadToEnd();
        }
    }
}

