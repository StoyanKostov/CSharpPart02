/* Write a program that reads a number and prints it as a decimal number, hexadecimal number,
 * percentage and in scientific notation. Format the output aligned right in 15 symbols. */

using System;
using System.Text;
 
class ReadAndPrintNumberFormated
{
    static void Main()
    {
        int number = InputNumber("Please, enter an integer (-999999 - 999999): ", -999999, 999999);

        Console.WriteLine("{0,22} : {1,15:D}","As decimal", number);
        Console.WriteLine("{0,22} : {1,15:X}", "As hexadecimal", number);
        Console.WriteLine("{0,22} : {1,15:P}", "As percentage", number);
        Console.WriteLine("{0,22} : {1,15:E}", "In scientific notation", number);
    }

    static int InputNumber(string message, int min, int max)
    {
        while (true)
        {
            int number;
            Console.Write(message);
            if (int.TryParse(Console.ReadLine(), out number) && number >= min && number <= max)
            {
                return number;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Please, enter valid number!");
                Console.WriteLine();
            }
        }
    }
}
