//02. Write a program that concatenates two text files into another text file.

using System;
using System.Text;
using System.IO;


class ConcatenatesTwoFileInOne
{
    static void Main()
    {
        try
        {
            StreamReader readerFirstFile = new StreamReader(@"C:\example1.txt", Encoding.GetEncoding("ASCII"));
            StreamReader readerSecondFile = new StreamReader(@"C:\example2.txt", Encoding.GetEncoding("ASCII"));
            using (readerFirstFile)    // read and write first file
            {
                StreamWriter writer = new StreamWriter(@"C:\example3.txt", false, Encoding.GetEncoding("ASCII"));
                using (writer)
                {
                    string s;
                    while ((s = readerFirstFile.ReadLine()) != null)
                    {
                        writer.WriteLine(s);
                    }

                }
            }
            using (readerSecondFile)   //read and append(true) second file to first file
            {
                StreamWriter writer = new StreamWriter(@"C:\example3.txt", true, Encoding.GetEncoding("ASCII"));
                using (writer)
                {
                    string s;
                    while ((s = readerSecondFile.ReadLine()) != null)
                    {
                        writer.WriteLine(s);
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
