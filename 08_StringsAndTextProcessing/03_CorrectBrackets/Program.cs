/// Write a program to check if in a given expression the brackets are put correctly.
/// Example of correct expression: ((a+b)/5-d).
/// Example of incorrect expression: )(a+b)).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CorrectBrackets
{
    static void Main(string[] args)
    {
        bool result = false;

        // Console input
        Console.WriteLine("Enter expression to be validated: ");
        string inputStr = Console.ReadLine();

        // Main Logic - Number of all open and close brakets must be equal and first braket must be opne braket
        int openBrakets = symbolCounter('(', inputStr);
        int closeBrakets = symbolCounter(')', inputStr);

        if ((openBrakets == closeBrakets) && (inputStr.IndexOf('(') < inputStr.IndexOf(')')))
        {
            result = true;
        }

        // Console output
        Console.WriteLine("The brakets are put correctly: {0}", result);
    }

    // Help method that counts given symbol
    private static int symbolCounter(char symbol, string inputStr)
    {
        int counter = 0;
        int index = inputStr.IndexOf(symbol);
        int nextIndex = index + 1;

        while (index > -1) // If not such char IndexOf returns -1
        {
            index = inputStr.IndexOf(symbol, nextIndex);
            nextIndex = index + 1;
            counter++;
        }

        return counter;
    }
}
