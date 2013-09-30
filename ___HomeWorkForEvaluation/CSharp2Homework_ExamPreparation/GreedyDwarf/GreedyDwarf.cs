//75 points

using System;

    class GreedyDwarf
    {
        static void Main()
        {
                string input = Console.ReadLine();

                int[] valley = ReadingInput(input);

                int numberOfPatterns = int.Parse(Console.ReadLine());
                string[] line = new string[numberOfPatterns];
                int[][] pattern = new int[numberOfPatterns][];

                for (int i = 0; i < numberOfPatterns; i++)
                {
                    line[i] = Console.ReadLine();
                    pattern[i] = ReadingInput(line[i]);
                }

                int maxCoins = 0;

                for (int patt = 0; patt < numberOfPatterns; patt++)
                {
                    int[] tempValley = new int[valley.Length];
                    Array.Copy(valley, tempValley, valley.Length);

                    int coinsCollected = 0;
                    int currPosition = 0;
                    int i = 0;

                    while (currPosition < tempValley.Length && currPosition >= 0)
                    {
                        if (tempValley[currPosition] == 2000)
                        {
                            break;
                        }

                        coinsCollected += tempValley[currPosition];
                        tempValley[currPosition] = 2000;
                        currPosition += pattern[patt][i];

                        if (i == pattern[patt].Length - 1)
                        {
                            i = 0;
                        }
                        else
                        {
                            i++;
                        }
                    }

                    if (maxCoins < coinsCollected)
                    {
                        maxCoins = coinsCollected;
                    }

                }

                Console.WriteLine(maxCoins);
            }
        

        private static int[] ReadingInput(string input)
        {
            string[] valleyString = input.Split(',');
            int[] valley = new int[valleyString.Length];

            for (int i = 0; i < valley.Length; i++)
            {
                valley[i] = int.Parse(valleyString[i]);
            }

            return valley;
        }
    }

