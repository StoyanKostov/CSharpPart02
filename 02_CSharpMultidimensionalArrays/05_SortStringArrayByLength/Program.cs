using System;
using System.Collections.Generic;
using System.Linq;

class MaximalSum
{
    static void Main(string[] args)
    {
        /// You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).
        
        // Declare and initialize the matrix
        string[] inputArray = { "a", "abGDEJ", "abvg", "abv", "abvgd"};


        // Main Logic
        Array.Sort(inputArray, (x, y) => (x.Length).CompareTo(y.Length));

        // Consol output
        foreach (var item in inputArray)
    	{
    		 Console.WriteLine(item);
    	}
    }
}
