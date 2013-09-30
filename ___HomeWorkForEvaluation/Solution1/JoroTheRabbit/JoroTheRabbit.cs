using System;

class JoroTheRabbit
{
    static void Main(string[] args)
    {
        int[] numbers;
        string input = Console.ReadLine();
        string[] inputNumbers = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

        numbers = new int[inputNumbers.Length];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(inputNumbers[i]);
        }

        int bestPath = 0;

        for (int startIndex = 0; startIndex < numbers.Length; startIndex++)
        {
            for (int step = 1; step < numbers.Length; step++)
            {
                int index = startIndex;
                int currentPath = 1;
                int next = (index + step); //% numbers.Length;
                if (next >= numbers.Length)
                {
                    next = next - numbers.Length;
                }

                while (numbers[index] < numbers[next]) //(next != startIndex) &&
                {
                    currentPath++;
                    index = next;
                    next = (index + step) % numbers.Length;
                }

                if (bestPath < currentPath)
                {
                    bestPath = currentPath;
                }
            }
        }
        Console.WriteLine(bestPath);
    }
}