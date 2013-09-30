/// Write a program that reads a text file containing a list of strings,
/// sorts them and saves them to another text file. 

using System;
using System.IO;
using System.Collections.Generic;

class SortStrings
{
    static void Main(string[] args)
    {

        try
        {
            // Creates and fills array with file lines
            List<string> inputArray = new List<string>();
            foreach (string line in File.ReadLines("text01.txt"))
            {
                inputArray.Add(line);
            }

            // Sort array
            inputArray.Sort();

            // Write array to file
            using (StreamWriter sr = new StreamWriter("result.txt"))
            {
                foreach (string item in inputArray)
                {
                    sr.WriteLine(item);
                }
            }
            
            Console.WriteLine("Succes!");
        }
        catch (Exception e)
        {
            // Let the user know what went wrong.
            Console.Error.WriteLine("The process failed: {0}", e.Message);
        }
    }
}

