/// Write a program that reads from the console a string of maximum 20 characters. 
/// If the length of the string is less than 20, the rest of the characters should be filled with '*'. 
/// Print the result string into the console.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FillRestOfFixedLengthString
{
    static void Main(string[] args)
    {
        // Console input
        Console.WriteLine("Enter string: ");
        string inputStr = Console.ReadLine();

        // Main Logic
        int maxLength = 20;
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < maxLength; i++)
        {
            if (i < inputStr.Length)
            {
                sb.Append(inputStr[i]);
            }
            else
            {
                sb.Append('*');
            }
        }

        // Console output
        Console.WriteLine(sb.ToString());
    }
}

