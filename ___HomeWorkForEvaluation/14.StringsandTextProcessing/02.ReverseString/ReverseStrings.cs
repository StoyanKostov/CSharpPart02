// Write a program that reads a string, reverses it and prints the result at the console.
// Example: "sample"  "elpmas".

using System;
using System.Text;
class ReverseStrings
{
    static void Main()
    {
        Console.Write("Please, enter a string: ");
        string input = Console.ReadLine();
        string result = ReverseString(input);
        Console.WriteLine("The reversed string is: {0}", result);
    }

    static string ReverseString(string inputString)
    {
        StringBuilder result = new StringBuilder(inputString.Length);
        for (int i = inputString.Length - 1; i >= 0; i--)
        {
            result.Append(inputString[i]);
        }
        return result.ToString();
    }
}