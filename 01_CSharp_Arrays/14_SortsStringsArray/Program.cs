using System;
using System.Collections.Generic;
using System.Linq;

class SortsStringsArray
{
    static void Main(string[] args)
    {
        /// Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).
        Console.WriteLine("Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).");

        // Consol Input
        Console.Write("Write down string array with element separated by space: ");
        string input = Console.ReadLine();
        string[] stringArray = input.Split(' ');
        List<string> sortedStringList = stringArray.ToList();

        // Main Logic – Recursion
        sortedStringList = QuickSortAlgorithm(sortedStringList);


        // Consol Output
        for (int i = 0; i < sortedStringList.Count; i++)
        {
            Console.WriteLine("Index {0}: {1}", i, sortedStringList[i]);
        }
    }

    private static List<string> QuickSortAlgorithm(List<string> listArray)
    {
        if (listArray.Count > 1)
        {
            List<string> leftSubArray = new List<string>();
            List<string> rightSubArray = new List<string>();
            string pivotValue = listArray[listArray.Count / 2];

            // Logic of quick sort algorithm – What's smaller than chosen pivot goes left and what's bigger goes right. 
            foreach (var item in listArray)
            {
                if (String.Compare(item, pivotValue) < 0)
                {
                    leftSubArray.Add(item);
                }
                else if (String.Compare(item, pivotValue) > 0)
                {
                    rightSubArray.Add(item);
                }
            }

            // Concatenates the tree parts – left, pivot, right
            listArray.Clear();
            listArray.AddRange(leftSubArray);
            listArray.Add(pivotValue);
            listArray.AddRange(rightSubArray);

            // Recursion occurs
            QuickSortAlgorithm(leftSubArray);
            QuickSortAlgorithm(rightSubArray);
        }
        return listArray;
    }
}

