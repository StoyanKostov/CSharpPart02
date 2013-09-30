/// Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
/// Each of the numbers that will be added could have up to 10 000 digits.

using System;
using System.Collections.Generic;
using System.Linq;

class AddsIntegers
{
    static void AddIntegers(int[] firstArray, int[] secondArray)
    {
        List<int> sumArray = new List<int>();
        int remainder = 0;
        bool firstIsBigger = false;

        // Get min length
        int minArrayLength = firstArray.Length;
        int maxArrayLength = secondArray.Length;
        if (firstArray.Length > secondArray.Length)
        {
            minArrayLength = secondArray.Length;
            maxArrayLength = firstArray.Length;
            firstIsBigger = true;
        }

        // Revers Arrays
        Array.Reverse(firstArray);
        Array.Reverse(secondArray);

        // Loops till the shorter array ends
        for (int i = 0; i < minArrayLength; i++)
        {

            if ((firstArray[i] + secondArray[i]) >= 10)
            {
                sumArray.Add((firstArray[i] + secondArray[i]) % 10 + remainder);
                remainder = 1;
            }
            else
            {
                sumArray.Add(firstArray[i] + secondArray[i] + remainder);
                remainder = 0;
            }
        }

        // Start to loop from where shorter array ends in order to add the rest of longer array
        for (int k = minArrayLength; k < maxArrayLength; k++)
        {
            if (!firstIsBigger)
            {
                if (secondArray[k] + remainder >= 10)
                {
                    sumArray.Add(secondArray[k] + remainder);
                    remainder = 1;
                }
                else
                {
                    sumArray.Add(secondArray[k] + remainder);
                    remainder = 0;
                }

            }
            else
            {
                if (firstArray[k] + remainder >= 10)
                {
                    sumArray.Add(firstArray[k] + remainder);
                    remainder = 1;
                }
                else
                {
                    sumArray.Add(firstArray[k] + remainder);
                    remainder = 0;
                }
            }
        }

        if (remainder == 1)
        {
            sumArray.Add(remainder);
        }
        
        sumArray.Reverse();
        foreach (var item in sumArray)
        {
            Console.Write(item);
        }

    }

    static int[] StringToIntArray(string input)
    {
        int[] numbers = new int[input.Length];
        //char[] stringToArray = input.ToCharArray();

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = input[i] - 48;
        }

        return numbers;
    }

    static void Main(string[] args)
    {
        // Consol input
        Console.WriteLine("Enter first number: ");
        string firstNumber = Console.ReadLine();

        Console.WriteLine("Enter second number: ");
        string secondNumber = Console.ReadLine();

        // String to int arrays
        int[] firstArray = StringToIntArray(firstNumber);
        int[] secondArray = StringToIntArray(secondNumber);

        //Call Add Method
        AddIntegers(firstArray, secondArray);
    }
}

