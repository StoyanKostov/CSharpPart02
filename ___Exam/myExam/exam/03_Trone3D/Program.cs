using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Math;

class Trone3D
{
    static void Main(string[] args)
    {


        // Input
        string[] inputXYZ = Console.ReadLine().Split();
        string playerRed = Console.ReadLine();
        string playerBlue = Console.ReadLine();

        int x = int.Parse(inputXYZ[0]);
        int y = int.Parse(inputXYZ[1]);
        int z = int.Parse(inputXYZ[2]);

        List<int> pathPlayerRedX = new List<int>();
        List<int> pathPlayerRedY = new List<int>();
        List<int> pathPlayerBlueX = new List<int>();
        List<int> pathPlayerBlueY = new List<int>();

        // Create Game Field
        int[,] gameField = new int[x, (y * 2 + z * 2)];

        int[] playerRedCoodinates = { x / 2, y / 2 };
        int[] playerBlueCoodinates = { x / 2, y + z + y / 2 };

        pathPlayerRedX.Add(playerRedCoodinates[0]);
        pathPlayerRedY.Add(playerRedCoodinates[1]);
        pathPlayerBlueX.Add(playerBlueCoodinates[0]);
        pathPlayerBlueY.Add(playerBlueCoodinates[1]);

        // game start
        for (int i = 0; i < playerRed.Length; i++)
        {

            coordinateUpdate(playerRedCoodinates, playerRed[i]);
            coordinateUpdate(playerBlueCoodinates, playerBlue[i]);

            pathPlayerRedX.Add(playerRedCoodinates[0]);
            pathPlayerRedY.Add(playerRedCoodinates[1]);
            pathPlayerBlueX.Add(playerBlueCoodinates[0]);
            pathPlayerBlueY.Add(playerBlueCoodinates[1]);

            if ((playerRedCoodinates[0] > x || playerRedCoodinates[0] < 0) && (playerBlueCoodinates[0] > x || playerBlueCoodinates[0] < 0))
            {
                Console.WriteLine("DRAW");
                Console.WriteLine(Math.Abs(playerRedCoodinates[0] - (x / 2)) + Math.Abs(playerRedCoodinates[1] - (y / 2)));
                break;
            }
            if (playerRedCoodinates[0] > x || playerRedCoodinates[0] < 0)
            {
                Console.WriteLine("BLUE");
                Console.WriteLine(Math.Abs(playerRedCoodinates[0] - (x / 2)) + Math.Abs(playerRedCoodinates[1] - (y / 2)));
                break;
            }
            if (playerBlueCoodinates[0] > x || playerBlueCoodinates[0] < 0)
            {
                Console.WriteLine("RED");
                Console.WriteLine(Math.Abs(playerRedCoodinates[0] - (x / 2)) + Math.Abs(playerRedCoodinates[1] - (y / 2)));
                break;
            }

            if (pathPlayerRedX.Contains(playerBlueCoodinates[0]) && pathPlayerRedY.Contains(playerBlueCoodinates[1]))
            {
                Console.WriteLine("RED");
                Console.WriteLine(Math.Abs(playerRedCoodinates[0] - (x / 2)) + Math.Abs(playerRedCoodinates[1] - (y / 2)));
                break;
            }
            if (pathPlayerBlueX.Contains(playerRedCoodinates[0]) && pathPlayerBlueY.Contains(playerRedCoodinates[1]))
            {
                Console.WriteLine("BLUE");
                Console.WriteLine(Math.Abs(playerRedCoodinates[0] - (x / 2)) + Math.Abs(playerRedCoodinates[1] - (y / 2)));
                break;
            }
        }

    }
    public static int[] coordinateUpdate(int[] playerCoodinates, char direction)
    {
        if (direction == 'M')
        {
            playerCoodinates[1] += 1;
        }
        else if (direction == 'L')
        {
            playerCoodinates[0] += 1;
        }
        else if (direction == 'R')
        {
            playerCoodinates[0] -= 1;
        }
        return playerCoodinates;
    }
}

