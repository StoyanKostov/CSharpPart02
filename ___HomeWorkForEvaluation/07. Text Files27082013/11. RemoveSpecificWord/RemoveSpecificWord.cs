//Write a program that deletes from a text file all words that start with the prefix "test". 
//Words contain only the symbols 0...9, a...z, A…Z, _.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

class RemoveSpecificWord
{
    static void Main()
    {
        string path = @"c:\temp\temp.txt";
        string pattern = "test";
        int patternLenght = pattern.Length;
        string output = null;
        string pathWrite = @"c:\temp\temp2.txt";

        using (StreamReader sr = new StreamReader(path))
        {
            using (StreamWriter sw = new StreamWriter(pathWrite))
            {

                while (sr.Peek() > -1)
                {
                    output = null;
                    string input = sr.ReadLine();
                    List<string> list = input.Split(' ').ToList();
                    foreach (string item in list)
                    {
                        if (item.Length >= patternLenght && item.Substring(0, patternLenght) != pattern)
                        {
                            output = output + " " + item;
                        }
                        else if (item.Length < patternLenght)
                        {
                            output = output + " " + item;
                        }
                    }
                    sw.WriteLine(output);
                    Console.WriteLine(output);
                }
            }
        }
    }
}
