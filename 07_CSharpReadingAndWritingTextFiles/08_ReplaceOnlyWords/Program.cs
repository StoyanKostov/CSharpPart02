/// Modify the solution of the previous problem to replace only whole words (not substrings).

using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class ReplaceWords
{
    static void Main(string[] args) /// НЕ УСПЯХ ДА Я ЗАВЪРША, НЕ РАБОТИ
    {
        try
        {
            string original =  "start";
            //string pattern = String.Format(@"\b{0}\b", original);
            string pattern = new Regex(@"\bstart\b");

            string changed = "finish";
            List<string> inputArray = new List<string>();

            // Create array with changes
            foreach (string line in File.ReadLines("text01.txt"))
            {
                if (line.Contains(pattern))
                {
                    inputArray.Add(line.Replace(original, changed));
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

