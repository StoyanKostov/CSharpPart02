using System;
using System.Collections.Generic;
using System.Text;

class ConsoleJustification
{
    private static string EnterWhitespase(int charOnLines, string line)
    {
        string[] shortLine = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int whitespase = shortLine.Length - 1;
        int allSpaces = charOnLines - line.Length + 1 + whitespase;
        line = string.Empty;

        foreach (string w in shortLine)
        {
            int ws;
            if (allSpaces > whitespase)
            {
                ws = allSpaces / whitespase + 1;
            }
            else
            {
                ws = allSpaces / whitespase;
            }

            line += string.Format("{0}{1}", w, " ".PadRight(ws));
            allSpaces--;
            if (allSpaces == 0)
            {
                return line;
            }
        }

        return line;
    }

    static void Main()
    {
        int numOfLines = int.Parse(Console.ReadLine());
        int charOnLines = int.Parse(Console.ReadLine());
        List<string> text = new List<string>();

        for (int i = 0; i < numOfLines; i++)
        {
            text.AddRange(Console.ReadLine().Split(new char[] { ',', ' ' },
                StringSplitOptions.RemoveEmptyEntries));
        }

        StringBuilder justifaed = new StringBuilder();

        string line = string.Empty;

        foreach (string word in text)
        {
            if ((line + word).Length <= charOnLines)
            {
                line += string.Format("{0}", word);
                if (line.Length < charOnLines )
                {
                    line += " ";
                }
            }
            else
            {
                if ((charOnLines > line.Length) || (line[line.Length - 1] == ' '))
                {
                    line = EnterWhitespase(charOnLines, line);
                }

                justifaed.AppendLine(line);
                line = string.Format("{0} ", word);
            }            
        }
        justifaed.AppendLine(line);

        Console.WriteLine("\n{0}",justifaed.ToString());
    }
}