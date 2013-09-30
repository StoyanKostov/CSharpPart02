/*07. Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file. 
Ensure it will work with large files (e.g. 100 MB).*/

using System;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;


class ReplacesStartWithFinish
{
    static void Main()
    {
        try
        {
            StreamReader readerStratFile = new StreamReader(@"C:\Elly-documents\C#\start2.TXT");
            StreamWriter writerFinish = new StreamWriter(@"C:\Elly-documents\C#\finish2.TXT");
            using (readerStratFile)
            {
                using (writerFinish)
                {
                    string line;
                    while ((line = readerStratFile.ReadLine()) != null)
                    {
                        writerFinish.WriteLine(line.Replace("start", "finish"));
                    }
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("The process failed: {0}", e.ToString());
        }
    }
}
