/* 06. Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file. Example:
	Ivan			George
	Peter	->		Ivan
	Maria			Maria
	George			Peter
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


class WriteSortedList
{
    static void Main()
    {
        try
        {
            List<string> unsorted = new List<string>();
            StreamReader names = new StreamReader(@"C:\names.txt", Encoding.GetEncoding("windows-1251"));
            using (names)
            {
                string currentLine;
                while ((currentLine = names.ReadLine()) != null)
                {
                    unsorted.Add(currentLine);
                }
            }

            unsorted.Sort();
            StreamWriter writer = new StreamWriter(@"C:\sorted.txt", false, Encoding.GetEncoding("windows-1251"));
            using (writer)
            {
                for (int i = 0; i < unsorted.Count; i++)
                {
                    writer.WriteLine((unsorted[i]));
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("The process failed: {0}", e.ToString());
        }
    }
}

