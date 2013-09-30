/// Write a program that reads a string, reverses it and prints the result at the console.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReverseString
{
    static void Main(string[] args)
    {
        // Console input
        Console.WriteLine("Enter string to be reversed: ");
        string inputStr = Console.ReadLine();
        string reversedStr = string.Empty;

        // Main Logic
        reversedStr = ReverseStr(inputStr);

        // Console output
        Console.WriteLine(reversedStr);
    }

    // Help method
    public static string ReverseStr(string s)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = s.Length - 1; i >= 0; i--)
        {
            sb.Append(s[i]);
        }
        return sb.ToString();
    }
}