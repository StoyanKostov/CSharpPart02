// Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).
// It's Like my first Exercise

using System;
using System.Collections.Generic;
using System.Linq;

class SignedIntegerToBinary 
{
    static void Main(string[] args)
    {
        //Console Input
        Console.WriteLine("Write a decimal number to covert: ");
        string input = Console.ReadLine();
        int inputNumber = int.Parse(input);

        //Main Logic
        List<int> bits = new List<int>();
        int toBase = 2;
        int bit = 0;
        bool isNegative = false;

        if (inputNumber < 0)
        {
            isNegative = true;
            inputNumber = Math.Abs(inputNumber);
        }

        while (inputNumber > 0)
        {
            bit = inputNumber % toBase;
            inputNumber = inputNumber / toBase;
            bits.Insert(0, bit);
        }

        if (isNegative)
        {
            // Invert bits Exaple 0100 to 1011
            for (int i = 0; i < bits.Count; i++)
            {
                if (bits[i] == 1)
                {
                    bits[i] = 0;
                }
                else
                {
                    bits[i] = 1;
                }
            }

            // add 1 Exaple 1011 equals 1100
            bits[bits.Count - 1] = bits[bits.Count - 1] + 1;
            for (int j = bits.Count - 1; j > 0; j--)
            {
                if (bits[j] == 2)
                {
                    bits[j] = 0;
                    bits[j - 1] = bits[j - 1] + 1;
                }
            }
            // Add bits = 1 to the rest bits Exaple  1111 1100 (8bit)
            for (int i = bits.Count; i < 32; i++)
            {
                bits.Insert(0, 1);
            }
        }

        //Console output
        foreach (var item in bits)
        {
            Console.Write(item);
        }
    }
}

