/// Write a program that reads a text file and inserts line numbers in front of each of its lines. 
/// The result should be written to another text file.

using System;
using System.IO;

class NumerateTextLines
{
    static void Main(string[] args)
    {
        try
        {
            using (StreamWriter resultWriter = new StreamWriter("resultText01.txt"))
            {
                using (StreamReader sr = new StreamReader("text01.txt"))
                {
                    int lineNum = 0;
                    string line = string.Empty;
                    while (true)
                    {
                        lineNum++;
                        line = sr.ReadLine();
                        if (line == null) // Breaks before write down last line with Null value (just empty line with ist number)
                        {
                            break;
                        }
                        resultWriter.WriteLine("{0}. {1}", lineNum, line);
                    }
                }
            }
            Console.WriteLine("Success!");
        }
        catch (Exception e)
        {
            // Let the user know what went wrong.
            Console.Error.WriteLine("The process failed: {0}", e.Message);
        }
    }
}

