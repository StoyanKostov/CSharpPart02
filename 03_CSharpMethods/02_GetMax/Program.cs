using System;
using System.Collections.Generic;
using System.Linq;

class Max
{
    /// Write a method GetMax() with two parameters that returns the bigger of two integers. 
    /// Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().

    static int GetMax(int a, int b)
    {
        int max = a;
        if (a < b)
        {
            max = b;
        }
        return max;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Write a program that reads 3 integers from the console and prints the biggest of them");

        // Consol Input
        Console.Write("Write your first number: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Write your first number: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Write your first number: ");
        int c = int.Parse(Console.ReadLine());
        
        // Main Logic
        int biggerNumber = GetMax(a, b);
        int biggestNumber = GetMax(biggerNumber, c);


        //Consol output
        Console.WriteLine("The biggest number is: {0}", biggestNumber);
    }
}

