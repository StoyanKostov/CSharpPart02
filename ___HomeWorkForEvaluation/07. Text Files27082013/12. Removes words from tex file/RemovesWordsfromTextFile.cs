// 12. Write a program that removes from a text file all words listed in given another text file.Handle all possible exceptions in your methods.

using System;
using System.IO;
using System.Text.RegularExpressions;


class RemovesWordsfromTextFile
{
    static void Main()
    {
        try
        {
            StreamReader readerFileTobeRemove = new StreamReader(@"C:\Elly-documents\C#\Texts\FileToBeRemove.TXT");
            StreamWriter readerFileOutput = new StreamWriter(@"C:\Elly-documents\C#\Texts\FileOutput.TXT");

            string words = @"\b(" + String.Join("|", File.ReadAllLines(@"C:\Elly-documents\C#\Texts\FileList.TXT")) + @")\b";

            using (readerFileTobeRemove)
            {
                using (readerFileOutput)
                {
                    string line;
                    while ((line = readerFileTobeRemove.ReadLine()) != null)
                    {
                        string text = Regex.Replace(line, words, String.Empty);
                        if (!String.IsNullOrWhiteSpace(text))
                        {
                            //Console.WriteLine(text);  //print the same results on the console also
                            readerFileOutput.WriteLine(Regex.Replace(line, words, String.Empty));
                        }
                    }
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("{0}:{1}", e.GetType().Name, e.Message);
        }
    }
}
