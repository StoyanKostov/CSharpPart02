using System;

class StringSplit
{
    static void Main()
    {
        string sequence = "43 -68.8 -9 23 3.56";
        
        double sum = 0;

        string[] numbers = sequence.Split(' ');

        foreach (var num in numbers)
        {
            sum += double.Parse(num);
        }

        Console.WriteLine(sum);
    }
}
