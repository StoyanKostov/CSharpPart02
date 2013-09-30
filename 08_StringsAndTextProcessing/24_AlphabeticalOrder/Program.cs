/// Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class AlphabeticalOrder
{
    static void Main(string[] args)
    {
        Console.Write("Enter words separated by space: ");
        string[] words = Console.ReadLine().Split(' ');
        Array.Sort(words);
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
    }
}