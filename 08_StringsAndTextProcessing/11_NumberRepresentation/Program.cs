/// Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation. 
/// Format the output aligned right in 15 symbols.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NumberRepresentation
{
    static void Main(string[] args)
    {
        // Console input
        Console.Write("Enter number : ");
        int number = int.Parse(Console.ReadLine());

        // Main Logic
        RepresentNumber(number);
    }

    static void RepresentNumber(int number)
    {
        Console.WriteLine("{0,15:d} : Decimal", number);
        Console.WriteLine("{0,15:X4} : Hexadecimal", number);
        Console.WriteLine("{0,15:p} : Percent", number);
        Console.WriteLine("{0,15:e} : Scientific", number);
        Console.WriteLine();
    }
}