/* Write a program that reads a string from the console and prints all different letters
 * in the string along with information how many times each letter is found. */

using System;
using System.Text;

class CountDifferentLetters
{
    static void Main()
    {
        Console.Write("Please, enter an string: ");
        string inString = Console.ReadLine();

        int[] letters = new int[65536]; //Number of symbols in Unicode

        for (int i = 0; i < inString.Length; i++)
        {
            if (char.IsLetter(inString[i]))
            {
                letters[(int)inString[i]]++;
            }
        }

        Console.WriteLine("Letters founded in the string:");
        for (int i = 0; i < letters.Length; i++)
        {
            if (letters[i] > 0)
            {
                Console.WriteLine("{0} - {1}", (char)i, letters[i]);
            }
        }
    }
}