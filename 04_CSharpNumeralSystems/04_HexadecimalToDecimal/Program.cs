/// Write a program to convert hexadecimal numbers to their decimal representation.

using System;
using System.Collections.Generic;
using System.Linq;

class HexadecimalToDecimal
{

    static void Main()
    {
        Console.WriteLine("Write a hexadecimal number to covert to decimal: ");
        string input = Console.ReadLine();
        int result = 0;
        int toBase = 16;
        int digit = 0;
        int Pow = input.Length - 1;

        for (int i = 0; i < input.Length; i++)
        {
            switch (input[i])
            {
                case 'A':
                case 'a':
                    digit = 10;
                    break;
                case 'B':
                case 'b':
                    digit = 11;
                    break;
                case 'C':
                case 'c':
                    digit = 12;
                    break;
                case 'D':
                case 'd':
                    digit = 13;
                    break;
                case 'E':
                case 'e':
                    digit = 14;
                    break;
                case 'F':
                case 'f':
                    digit = 15;
                    break;
                default: digit = int.Parse(Convert.ToString(input[i]));
                    break;
            }

            result += digit * (int)Math.Pow(toBase, Pow);
            Pow -= 1;
        }

        Console.WriteLine(result);
    }
}