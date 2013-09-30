using System;
using System.Text;
class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter a nubmer:");
        int number = int.Parse(Console.ReadLine());
        string result = string.Format("{0,15:D}\n{0,15:X4}\n{0,15:P0}\n{0,15:E}", number);
        Console.WriteLine(result);

    }
}

