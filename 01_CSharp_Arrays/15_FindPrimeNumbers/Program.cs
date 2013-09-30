using System;
using System.Collections.Generic;
using System.Linq;

class FindPrimeNumbers

{
    static void Main(string[] args)
    {
        /// Write a program that finds all prime numbers in the range [1...10 000 000]. Use the sieve of Eratosthenes algorithm (find it in Wikipedia).
        Console.WriteLine("Write a program that finds all prime numbers in the range [1...10 000 000]. Use the sieve of Eratosthenes algorithm (find it in Wikipedia).");

        // Allocate bool array
        int numbersRange = 30;
        bool[] primesCollection = new bool[numbersRange + 1];

        // Main logic – Recursion
        EratosthenesAlgorithm(primesCollection);

        // Consol Output
        for (int i = 2; i < primesCollection.Length; i++)
        {
            if (!primesCollection[i])
            {
                Console.WriteLine(i);
            }
           
        }
    }

    private static bool EratosthenesAlgorithm(bool[] primesCollection, int index = 2)
    {
        // elements of bool array are false by defoult
        // Finds the first number than is not multiple of previous prime number(index) in the array (value -> false)
        if (!primesCollection[index])
        {
            // Change value of all multiples of prime number(index) to opposite bool (true)
            for (int i = index * 2; i < primesCollection.Length; i += index)
            {
                primesCollection[i] = true;
            }
        }
        else
        {
            // Ends Recursion
            return false;
        }
        
        // Increment the Index 
        index += 1;

        return EratosthenesAlgorithm(primesCollection, index);
    }
}

