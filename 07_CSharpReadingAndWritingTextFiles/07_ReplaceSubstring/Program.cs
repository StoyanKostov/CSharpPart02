/// Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file.
/// Ensure it will work with large files (e.g. 100 MB).

using System;
using System.IO;
using System.Collections.Generic;

class ReplaceSubstring
{
    static void Main(string[] args)
    {
        try
        {
            string pattern = "start";
            string changed = "finish";
            List<string> inputArray = new List<string>();

            // Create array with changes
            foreach (string line in File.ReadLines("text01.txt"))
            {
                if (line.Contains(pattern))
                {
                    inputArray.Add(line.Replace(pattern, changed));
                }
                else
                {
                    inputArray.Add(line);
                }
            }

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

