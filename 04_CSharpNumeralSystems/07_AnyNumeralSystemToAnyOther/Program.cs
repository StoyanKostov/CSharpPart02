// Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).

using System;
using System.Collections.Generic;
using System.Linq;

class HexadecimalToDecimal
{

    static void Main(string[] args)
    {
        //Console Input
        Console.WriteLine("Write a binary number to covert: ");
        string input = Console.ReadLine();
        char[] inputCharArray = input.ToCharArray();

        //Main Logic

        //From any numeric system to decsimal
        int decimalResult = 0;
        int fromBase = 16;
        int reversedIndex = (input.Length - 1);
        int currentDidgit = 0;

        for (int i = 0; i < input.Length; i++)
        {
            switch (inputCharArray[reversedIndex])
            {
                case 'A':
                case 'a':
                    currentDidgit = 10;
                    break;
                case 'B':
                case 'b':
                    currentDidgit = 11;
                    break;
                case 'C':
                case 'c':
                    currentDidgit = 12;
                    break;
                case 'D':
                case 'd':
                    currentDidgit = 13;
                    break;
                case 'E':
                case 'e':
                    currentDidgit = 14;
                    break;
                case 'F':
                case 'f':
                    currentDidgit = 15;
                    break;
                default: currentDidgit = inputCharArray[reversedIndex] - 48;
                    break;
            }
            decimalResult += (currentDidgit) * (int)Math.Pow(fromBase, i);
            reversedIndex -= 1;
        }

        Console.WriteLine(decimalResult);

        //From decsimal to any numeric system

        List<int> bits = new List<int>();
        int bit = 0;
        int toBase = 2;

        while (decimalResult > 0)
        {
            bit = decimalResult % toBase;
            decimalResult = decimalResult / toBase;
            bits.Insert(0, bit);
        }

        //Console output
        foreach (var item in bits)
        {
            Console.Write(item);
        }
    }
}


