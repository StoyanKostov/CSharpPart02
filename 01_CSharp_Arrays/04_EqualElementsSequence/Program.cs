using System;

class EqualElementsSequence
{
    static void Main(string[] args)
    {
        /// Write a program that finds the maximal sequence of equal elements in an array.
        /// Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1} -> {2, 2, 2}

        int? currentElement = null;
        int? element = null;
        int maxSequence = 1;
        int currentSequence = 0;

        // Consol input
        Console.Write("Enter nummbers of the array separated by space: ");
        string input = Console.ReadLine();
        string[] arrNummbers = input.Split(' ');
        int[] arr = Array.ConvertAll<string, int>(arrNummbers, int.Parse);

        for (int i = 0; i < (arr.Length - 1); i++)
        {
            if (arr[i] == arr[i + 1])
            {
                currentSequence += 1;
                currentElement = arr[i];
            }
            else
            {
                currentSequence = 0;
            }

            if (currentSequence > maxSequence)
            {
                maxSequence = currentSequence;
                element = currentElement;
            }
        }
        Console.WriteLine("Maximal sequence of equal elements is {0}, {1} times.", element, maxSequence + 1);
    }
}