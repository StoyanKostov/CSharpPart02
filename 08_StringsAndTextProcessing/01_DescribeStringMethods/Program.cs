/// Describe the strings in C#. What is typical for the string data type? Describe the most important methods of the String class.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DescribeStringMethods
{
    static void Main(string[] args)
    {
        Console.WriteLine("String represents text as a immutable series of Unicode characters");
        Console.WriteLine("The most the most important methods as follows:");
        Console.WriteLine("length - Get lenght of the string");
        Console.WriteLine("Compare(String, String) - Compares two specified String objects and returns an integer that indicates their relative position in the sort order.");
        Console.WriteLine("Concat(String, String) - Concatenates two specified instances of String.");
        Console.WriteLine("IndexOf() - Reports the zero-based index of the first occurrence of the specified Unicode character or specified string in a string.");
        Console.WriteLine("LastIndexOf() - Reports the zero-based index of the last occurrence of the specified Unicode character or specified string in a string.");
        Console.WriteLine("Substring() - Retrieves a substring from this instance. The substring starts at a specified character position and continues to the end of the string.");
        Console.WriteLine("Split() - Returns a string array that contains the substrings in this instance that are delimited by elements of a specified Unicode character array.");
        Console.WriteLine("Replace() - replaces all occurrences of given string with another");
        Console.WriteLine("Remove() - deletes part of a string and produces new string as result");
        Console.WriteLine("ToUpper() - Returns a copy of this string converted to uppercase.");
        Console.WriteLine("ToLower() - Returns a copy of this string converted to lowercase.");
        Console.WriteLine("Trim() - Removes all leading and trailing white-space characters from the current String object.");
        Console.WriteLine("TrimStart() - Removes all leading occurrences of a set of characters specified in an array from the current String object.");
        Console.WriteLine("TrimEnd() - Removes all trailing occurrences of a set of characters specified in an array from the current String object.");
        Console.WriteLine("Equals() - Determines whether this instance and another specified String object have the same value.");
        Console.WriteLine("Contains - Returns a value indicating whether the specified String object occurs within this string");
        Console.WriteLine("ToCharArray - Copies the characters in this instance to a Unicode character array.");
    }
}

