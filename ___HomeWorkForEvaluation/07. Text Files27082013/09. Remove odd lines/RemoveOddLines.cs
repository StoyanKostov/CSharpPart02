// 09. Write a program that deletes from given text file all odd lines. The result should be in the same file.

using System;
using System.IO;
using System.Collections.Generic;

class RemoveOddLines
{
    static List<string> ReadOddLines()
    {
        List<string> odds = new List<string>();

        int n = 1;

        using (StreamReader input = new StreamReader(@"C:\Elly-documents\C#\Texts\input.TXT"))
        {
            for (string line; (line = input.ReadLine()) != null; n++)
            {
                if (n % 2 == 0)
                {
                    odds.Add(line);
                }
            }
            return odds;
        }
    }

    static void WriteLines(List<string> odds)
    {
        using (StreamWriter output = new StreamWriter(@"C:\Elly-documents\C#\Texts\input.TXT"))
        {
            foreach (string odd in odds)
            {
                output.WriteLine(odd);
            }
        }
    }

    static void Main()
    {
        WriteLines(ReadOddLines());
    }
}