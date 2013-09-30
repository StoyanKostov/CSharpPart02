/* Write a program that converts a string to a sequence of C# Unicode character literals.
 * Use format strings.
 * Sample input:  Hi!
 * Expected output:  \u0048\u0069\u0021 */

using System;
using System.Text;

class ConvertStringToUnicode
{
    static void Main()
    {
        //string inString = "Hi!";
        Console.WriteLine("Please, enter a string");
        string inString = Console.ReadLine();
        StringBuilder sb = new StringBuilder();

        foreach (char ch in inString)
        {
            sb.Append(string.Format("\\u{0:X4}", (int)ch));
        }
        
        string output = sb.ToString();
        Console.WriteLine("The string represented as C# Unicode character literals is: ");
        Console.WriteLine(output);
    }
}