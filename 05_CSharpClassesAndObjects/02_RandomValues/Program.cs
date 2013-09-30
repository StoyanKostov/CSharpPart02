///Write a program that generates and prints to the console 10 random values in the range [100, 200].

using System;
using System.Collections.Generic;

class RandomValues
{
    static void Main(string[] args)
    {
        // Create instance of class Random outside of the for loop
        Random random = new Random();

        int? randomNumber = null;
        
        for (int i = 0; i < 10; i++)
        {
            randomNumber = random.Next(100, 201);
            Console.WriteLine(randomNumber);
        }
    }
}
