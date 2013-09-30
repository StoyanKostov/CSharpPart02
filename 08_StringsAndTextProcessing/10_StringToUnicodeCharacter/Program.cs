/// Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StringToUnicodeCharacter
{
    static void Main(string[] args)
    {
        string outputStr;

        // Console input
        Console.Write("Enter some string to be coverted to unicode characters: ");
        string inputStr = Console.ReadLine();

        // Main Logic
        outputStr = StringToUnicode(inputStr);

        //Consol Output
        Console.WriteLine(outputStr);
    }

    private static string StringToUnicode(string inputString)
    {
        StringBuilder sb = new StringBuilder();
        foreach (char c in inputString)
        {
            sb.Append("\\u").Append(String.Format("{0:x4}", (int)c));
        }
        return sb.ToString();
    }
}