//#3: Write a program that reads a text file and inserts line numbers in front of each of its lines. 
//The result should be written to another text file.

using System;
using System.IO;

class ReadAndCreateNewFile
{
    static void Main()
    {
        string pathRead = @"c:\temp\MyTestRead.txt";//file r read
        if (!File.Exists(pathRead)) // create a file to read from if not exists
        {
            StreamWriter streamWriter = new StreamWriter(pathRead);
            using (streamWriter)
            {
                streamWriter.WriteLine("LineA");
                streamWriter.WriteLine("LineB");
            }
        }
        else if (File.Exists(pathRead))//adds a new line to the file (this is to ensure file is nt empty)
        {
            using (StreamWriter streamWriter = File.AppendText(pathRead))
            using (streamWriter)
            {
                streamWriter.WriteLine("AddAnotherLine");
            }
        }

        string pathWrite = @"c:\temp\MyTestWrite.txt";//file to write
        if (!File.Exists(pathWrite))//create a file to write in if not exists
        {
            File.Create(pathWrite);
        }
        else if (File.Exists(pathWrite))//sets the contents of the file to write in to null
        {
            System.IO.File.WriteAllText(pathWrite, string.Empty);
        }

        int lineNumber = 0;

        //inserts line numbers in front of each of its lines into a new file
        try
        {
            using (StreamWriter writer = new StreamWriter(pathWrite))
            {
                using (StreamReader reader = new StreamReader(pathRead))
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        lineNumber++;
                        writer.WriteLine(Convert.ToString(lineNumber) + ": " + line);
                        line = reader.ReadLine();
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
