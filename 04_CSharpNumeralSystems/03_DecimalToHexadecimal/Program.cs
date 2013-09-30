/// Write a program to convert decimal numbers to their binary representation.

using System;
using System.Collections.Generic;
using System.Linq;

class DecimalToBinary
{
    static void Main(string[] args)
    {
        //Console Input
        Console.WriteLine("Write a decimal number to covert: ");
        string input = Console.ReadLine();
        int inputNumber = int.Parse(input);

        //Main Logic
        List<int> bits = new List<int>();
        int toBase = 16;
        int bit = 0;

        while (inputNumber > 0)
        {
            bit = inputNumber % toBase;
            inputNumber = inputNumber / toBase;
            bits.Insert(0, bit);
        }

        //Console output
        foreach (var item in bits)
        {
            switch (item)
            {
                case 10:
                    Console.Write("A");
                    break;
                case 11:
                    Console.Write("B");
                    break;
                case 12:
                    Console.Write("C");
                    break;
                case 13:
                    Console.Write("D");
                    break;
                case 14:
                    Console.Write("E");
                    break;
                case 15:
                    Console.Write("F");
                    break;
                default:
                    Console.Write(item);
                    break;
            }
        }
    }
}

