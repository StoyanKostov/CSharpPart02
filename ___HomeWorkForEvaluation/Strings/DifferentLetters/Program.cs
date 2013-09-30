using System;

class Program
{
    static void Main()
    {
        string str = Console.ReadLine();

        int[] values = new int['z' - 'a' + 1];

        foreach (char c in str.ToLower())
            if ('a' <= c && c <= 'z') values[c - 'a']++;

        for (int i = 0; i < values.Length; i++)
            if (values[i] != 0) Console.WriteLine("{0}: {1}", (char)(i + 'a'), values[i]);
    }
}