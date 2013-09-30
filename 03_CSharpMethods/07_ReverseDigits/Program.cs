/// Write a method that reverses the digits of given decimal number. Example: 256 to 652

using System;
using System.Collections.Generic;
using System.Linq;

class ReverseDigits
{
    static string Reverse(decimal number)
    {
        bool isNegative = false;

        if (number < 0)
        {
            isNegative = true;
            number = Math.Abs(number);
        }

        string stringNumber = number.ToString();
        char[] reversedCharArray = stringNumber.ToCharArray();
        Array.Reverse(reversedCharArray);

        // Convert Char Array to String
        string result = new string(reversedCharArray);

        if (isNegative)
        {
            result = result.Insert(0, "-");
        }
                
        return result;
    }

    static void Main(string[] args)
    {
        //Console Input
        Console.WriteLine("Write a decimal number to revers: ");
        decimal inputDecimal = decimal.Parse(Console.ReadLine());

        // Call method and Console output
        Console.WriteLine("Reversed Number is:\n{0}", Reverse(inputDecimal));
    }
}

