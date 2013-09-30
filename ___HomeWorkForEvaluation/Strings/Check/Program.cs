using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter some expresion: ");
        string expresion = Console.ReadLine();
        int countOpenBracket = 0;
        int countClosedBracket = 0;
        foreach (var ch in expresion)
        {
            if (ch == '(')
            {
                countOpenBracket++;
            }
            else if (ch == ')')
            {
                countClosedBracket++;
            }
        }
        if (countOpenBracket == countClosedBracket)
        {
            Console.WriteLine("Your expression is valid");
        }
        else
        {
            Console.WriteLine("Your expression is invalid");
        }
    }
}
