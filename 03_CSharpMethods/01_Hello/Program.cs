using System;
using System.Collections.Generic;
using System.Linq;

class Hello
{
    /// Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”). Write a program to test this method.

    static void SayHello()
    {
        Console.Write("Write down your name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Hello, {0}", name);
    }

    static void Main(string[] args)
    {
        SayHello();
    }
}

