using System;

class CompareArraysElementByElement
{
    static void Main(string[] args)
    {
        /// Write a program that reads two arrays from the console and compares them element by element.

        bool result = true;

        // Consol input
        Console.Write("Enter nummbers of the first array separated by space: ");
        string inputFirst = Console.ReadLine();
        string[] firstArrayNummbers = inputFirst.Split(' ');
        int[] firstArray = Array.ConvertAll<string, int>(firstArrayNummbers, int.Parse);

        Console.Write("Enter nummbers of the second array separated by space: ");
        string inputSecond = Console.ReadLine();
        string[] secondArrayNummbers = inputSecond.Split(' ');
        int[] secondArray = Array.ConvertAll<string, int>(secondArrayNummbers, int.Parse);

        // Main Logic
        if (firstArray.Length != secondArray.Length)  // Compares lengths of both
        {
            result = false;
        }
        else
        {
            for (int i = 0; i < firstArray.Length; i++) // If arrays have same lenght, compares them index by index
            {
                if (firstArray[i] != secondArray[i])
                {
                    result = false;
                    break;
                }
            }
        }

        // Consol output
        Console.WriteLine("Two arrayes are equal: {0}", result);
    }
}