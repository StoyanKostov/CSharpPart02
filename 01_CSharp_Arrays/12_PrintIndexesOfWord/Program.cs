using System;
using System.Collections.Generic;
using System.Linq;

class PrintIndexesOfWord
{
    static void Main(string[] args)
    {
        /// Write a program that creates an array containing all letters from the alphabet (A-Z). Read a word from the console and print the index of each of its letters in the array.
        Console.WriteLine("Write a program that creates an array containing all letters from the alphabet (A-Z). Read a word from the console and print the index of each of its letters in the array.");

        // Allocates char array with [A-Z]
        char[] letterArray = new char[26];
        int k = 65;

        for (int i = 0; i <= 25; i++)
        {
            letterArray[i] = Convert.ToChar(k);
            k += 1;
        }

        // Consol Input
        Console.Write("Enter word(All Caps): ");
        string inputWord = Console.ReadLine();

        // Main Logic
        char[] word = inputWord.ToCharArray();
        foreach (var item in word)
        {
            Console.WriteLine("The index of {0} is {1}", item, Array.IndexOf(letterArray, item));
        }
    }
}