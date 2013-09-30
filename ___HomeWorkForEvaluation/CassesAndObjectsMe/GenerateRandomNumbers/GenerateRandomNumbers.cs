using System;

class GenerateRandomNumbers
{
    private static Random generator = new Random();

    static void Main()
    {
        //Console.WriteLine("This program will genarate 10 random numbers in given range.");
        //Console.Write("Enter a minimal value: ");
        //int min = int.Parse(Console.ReadLine());
        int min = 100;

        //Console.Write("Enter maximal value: ");
        //int max = int.Parse(Console.ReadLine());
        int max =200;

        for (int i = 1; i < 10; i++)
        {
            Console.WriteLine(generator.Next(min, max + 1));
        }
    }
}
