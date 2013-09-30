using System;


namespace Laser
{
    class Laser
    {
        static void Main(string[] args)
        {
            int[] cuboidDimensions = FormatTheInputNumbers();
            int[] position = FormatTheInputNumbers();
            int[] laserDirection = FormatTheInputNumbers();

            bool[, ,] visited = new bool[cuboidDimensions[0] + 1, cuboidDimensions[1] + 1, cuboidDimensions[2] + 1];



            while (true)
            {
                visited[position[0], position[1], position[2]] = true;
                int[] nextPosition = new int[position.Length];

                for (int i = 0; i < nextPosition.Length; i++)
                {
                    nextPosition[i] = position[i] + laserDirection[i];
                }

                if (visited[nextPosition[0], nextPosition[1], nextPosition[2]] || CheckBorderCase(cuboidDimensions, nextPosition) > 1)
                {
                    Console.WriteLine("{0} {1} {2}", position[0], position[1], position[2]);
                    return;
                }

                if (CheckBorderCase(cuboidDimensions, nextPosition) == 1)
                {
                    ReverseDirection(cuboidDimensions, nextPosition, laserDirection);
                }

                for (int i = 0; i < position.Length; i++)
                {
                    position[i] = nextPosition[i];
                }
            }
        }

        static int[] FormatTheInputNumbers()
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] outputAsIntArray = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                outputAsIntArray[i] = int.Parse(input[i]);
            }
            return outputAsIntArray;
        }

        static int CheckBorderCase(int[] cuboidDimensions, int[] nextPosition)
        {
            int count = 0;

            for (int i = 0; i < nextPosition.Length; i++)
            {
                if (nextPosition[i] == 1 || nextPosition[i] == cuboidDimensions[i])
                {
                    count++;
                }
            }
            return count;

        }

        static void ReverseDirection(int[] cuboidDimensions, int[] nextPosition, int[] laserDirection)
        {
            for (int i = 0; i < nextPosition.Length; i++)
            {
                if (nextPosition[i] == 1 && laserDirection[i] == -1)
                {
                    laserDirection[i] *= -1;
                }
                else if (nextPosition[i] == cuboidDimensions[i] && laserDirection[i] == 1)
                {
                    laserDirection[i] *= -1;
                }
            }
        }
    }
}