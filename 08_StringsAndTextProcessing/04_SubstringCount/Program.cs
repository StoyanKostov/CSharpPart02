/// Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SubstringCount
{
    static void Main(string[] args)
    {
        //string inputStr = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";

        int result;

        // Console input
        Console.WriteLine("Enter string: ");
        string inputStr = Console.ReadLine();


        Console.WriteLine("Enter substring to count: ");
        string subStr = Console.ReadLine();

        // Main Logic
        result = substringCounter(subStr, inputStr);


        // Console output
        Console.WriteLine(result);
    }

    private static int substringCounter(string subString, string inputStr)
    {
        inputStr = inputStr.ToLower();
        int counter = 0;
        int index = inputStr.IndexOf(subString);
        int nextIndex = index + 1;

        while (index > -1) // If not such substring IndexOf returns -1
        {
            counter++;
            index = inputStr.IndexOf(subString, nextIndex);
            nextIndex = index + 1;
        }

        return counter;
    }
}
