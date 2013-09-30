// 08. Modify the solution of the previous problem to replace only whole words (not substrings).

using System;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;


class ReplacesWorrsInTextFile
{
    static void Main()
    {
        try
        {
            StreamReader readerStratFile = new StreamReader(@"C:\Elly-documents\C#\start2.TXT");
            StreamWriter writerFinish = new StreamWriter(@"C:\Elly-documents\C#\finish3.TXT");
            using (readerStratFile)
            {
                using (writerFinish)
                {
                    string line;
                    while ((line = readerStratFile.ReadLine()) != null)
                    {
                        //writerFinish.WriteLine(line.Replace("start", "finish")); //issue 7
                        writerFinish.WriteLine(Regex.Replace(line, @"\bstart\b", "finish")); //issue 8
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

