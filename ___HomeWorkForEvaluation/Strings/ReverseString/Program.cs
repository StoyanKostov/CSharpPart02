using System;

class Program
{
    static void Main()
    {
        string readedString = Console.ReadLine();
        char[] charr = readedString.ToCharArray();
        Array.Reverse(charr);
        Console.WriteLine(charr);


    }
}
