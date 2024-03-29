﻿using System;
using System.Text.RegularExpressions;

class Program
{
    static bool Palindrome(string str)
    {
        for (int i = 0; i < str.Length / 2; i++)
            if (str[i] != str[str.Length - 1 - i])
                return false;

        return true;
    }

    static void Main()
    {
        string str = "Static void Main() ABBA, using System lamal, exe.";

        foreach (Match item in Regex.Matches(str, @"\w+"))
            if (Palindrome(item.Value)) Console.WriteLine(item);

        foreach (Match item in Regex.Matches(str, @"\b(?<N>.)+.?(?<-N>\k<N>)+(?(N)(?!))\b"))
            Console.WriteLine(item);
    }
}