/// Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one. Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReplacesIidenticalletters
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter some text: ");
        string inputText = Console.ReadLine();

        StringBuilder sb = new StringBuilder(inputText);
        for (int i = 0, index = 0; i < sb.Length - 1; i++, index++)
        {
            char currentLatter = sb[i];
            while (index < sb.Length - 1 && currentLatter == sb[index + 1])
            {
                sb.Remove(index + 1, 1);
            }
        }
        Console.WriteLine(sb.ToString());
    }
}