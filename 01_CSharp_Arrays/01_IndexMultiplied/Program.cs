using System;

class IndexMultiplied
{
    static void Main(string[] args)
    {
        /// Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5. Print the obtained array on the console.

        // Allocates array of 20 integers
        int[] array = new int[20];

        // Main Logic
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i * 5;
            Console.WriteLine(array[i]);
        }
    }
}