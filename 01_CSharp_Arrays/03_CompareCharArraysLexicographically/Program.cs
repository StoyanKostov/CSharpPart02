using System;

class CompareCharArraysLexicographically
{
    static void Main(string[] args)
    {
        /// Write a program that compares two char arrays lexicographically (letter by letter).

        string result = " ";
        bool diffrentLength = true;

        // Consol input
        Console.Write("Enter chars for the first array: ");
        string firstArrayChars = Console.ReadLine();
        char[] firstArray = firstArrayChars.ToCharArray();
        int firstArrayLength = firstArray.Length;

        Console.Write("Enter chars for the second array: ");
        string secondArrayChars = Console.ReadLine();
        char[] secondArray = secondArrayChars.ToCharArray();
        int secondArrayLength = secondArray.Length;

        // Main Logic
        int smallerLength = firstArrayLength;

        if (firstArrayLength > secondArrayLength)
        {
            smallerLength = secondArrayLength;
        }

        for (int i = 0; i < smallerLength; i++)
        {
            if (firstArray[i] > secondArray[i])
            {
                result = "First Array > Second Array.";
                diffrentLength = false;
                break;
            }
            else if (firstArray[i] < secondArray[i])
            {
                result = "First Array < Second Array.";
                diffrentLength = false;
                break;
            }
        }

        if (diffrentLength)
        {
            if (firstArrayLength < secondArrayLength)
            {
                result = "First Array < Second Array.";
            }
            else if (firstArrayLength > secondArrayLength)
            {
                result = "First Array > Second Array.";
            }
        }

        // Consol output
        Console.WriteLine(result);
    }
}