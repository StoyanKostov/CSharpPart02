/// Write a program to convert binary numbers to their decimal representation.

using System;
using System.Collections.Generic;
using System.Linq;

class DecimalToBinary
{
    static void Main(string[] args)
    {
        //Console Input
        Console.WriteLine("Write a binary number to covert: ");
        string input = Console.ReadLine();
        int inputNumber = int.Parse(input);

        //Main Logic
        int result = 0;
        int toBase = 2;
        int reversedIndex = (input.Length - 1);

        for (int i = 0; i < input.Length; i++)
        {
            result += (input[reversedIndex] - '0') * (int)Math.Pow(toBase, i);
            reversedIndex -= 1;
        }

        //Console output
        Console.WriteLine(result);
    }
}

