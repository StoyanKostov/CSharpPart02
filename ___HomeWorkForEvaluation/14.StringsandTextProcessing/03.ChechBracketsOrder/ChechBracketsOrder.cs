/* Write a program to check if in a given expression the brackets are put correctly.
 * Example of correct expression: ((a+b)/5-d).
 * Example of incorrect expression: )(a+b)). */

using System;
using System.Collections.Generic;
using System.Text;

class ChechBracketsOrder
{
    static void Main()
    {
        Console.Write("Please, enter the expresion: ");
        string expresion = Console.ReadLine();

        string openBrackets = "({[";
        string closingBtackets = ")}]";
        Stack<char> brackets = new Stack<char>();
        bool isValid = true;

        for (int i = 0; i < expresion.Length && isValid; i++)
        {
            for (int bracket = 0; bracket < openBrackets.Length; bracket++)
            {
                if (expresion[i] == openBrackets[bracket])
                {
                    brackets.Push(expresion[i]);
                    break;
                }
            }
            for (int bracket = 0; bracket < closingBtackets.Length; bracket++)
            {
                if (expresion[i] == closingBtackets[bracket])
                {
                    if (brackets.Count == 0)
                    {
                        isValid = false;
                        break;
                    }
                    else if (brackets.Pop() != openBrackets[bracket])
                    {
                        isValid = false;
                        break;
                    }
                    break;
                }
            }
        }
        if (brackets.Count != 0)
        {
            isValid = false;
        }

        Console.WriteLine("The brackets in the expresion are put {0}correctly", isValid ? "" : "in");
    }
}