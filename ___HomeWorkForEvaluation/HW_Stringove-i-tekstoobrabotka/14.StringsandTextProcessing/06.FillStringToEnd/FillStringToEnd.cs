/* Write a program that reads from the console a string of maximum 20 characters.
 * If the length of the string is less than 20, the rest of the characters
 * should be filled with '*'. Print the result string into the console. */

using System;
using System.Text;

class FillStringToEnd
{
    static void Main()
    {
        string inString = InputString("Please, ether a string, max. 20 symbols: ", 0, 20);
        if (inString.Length < 20)
        {
            inString = inString + new string('*', 20 - inString.Length);
        }
        Console.WriteLine("The result string is: {0}",inString);
    }

    static string InputString(string message, int minLenght, int maxLenght)
    {
        while (true)
        {
            Console.Write(message);
            string inString = Console.ReadLine();
            if (inString.Length < minLenght || inString.Length > maxLenght)
            {
                Console.WriteLine();
                Console.WriteLine("Please, enter valid string!");
                Console.WriteLine();
            }
            else
            {
                return inString;
            }
        }
    }
}