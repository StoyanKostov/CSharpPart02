using System;

namespace GreedyDwarf
{
    class GreedyDwarf
    {
        static void Main()
        {

            string[] valleyInput = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int m = int.Parse(Console.ReadLine());

            int[] valleyAsInt = new int[valleyInput.Length];

            for (int i = 0; i < valleyAsInt.Length; i++)
            {
                valleyAsInt[i] = int.Parse(valleyInput[i]);
            }


            long maxSum = long.MinValue;

            while (m > 0)
            {
                long currentSum = 0;
                bool[] visited = new bool[valleyAsInt.Length];

                string[] patternInput = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int[] patternAsInt = new int[patternInput.Length];
                for (int i = 0; i < patternAsInt.Length; i++)
                {
                    patternAsInt[i] = int.Parse(patternInput[i]);
                }

                int step = 0;
                bool proceed = true;

                while (proceed == true)
                {
                    for (int i = 0; i < patternAsInt.Length; i++)
                    {
                        if (visited[step])
                        {
                            proceed = false;
                            break;
                        }
                        currentSum += valleyAsInt[step];
                        visited[step] = true;
                        if (step + patternAsInt[i] > valleyAsInt.Length - 1 || step + patternAsInt[i] < 0)
                        {
                            proceed = false;
                            break;
                        }
                        step += patternAsInt[i];
                    }
                }
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }

                m--;
            }
            Console.WriteLine(maxSum);
        }
    }
}
